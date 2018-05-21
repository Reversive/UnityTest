using Character_Classes;
using Stats;
using UnityEngine;
public class CharacterCreator : MonoBehaviour
{
    void Start()
    {
       
    }

    void OnGUI()
    {
        
        if (GUI.Button(new Rect(10, 10, 50, 50), "Create"))
        {
            var lPlayer = new Character(new Warrior());
            lPlayer.Name = "John doe";
            lPlayer.Description = "Lorem";
            lPlayer.Gold = 1000;
            lPlayer.Level = 1;
            lPlayer.Type.Stats.ForEach(Print);
            GameInfo.GetInstance().LocalPlayer = lPlayer;
        }
    }

    public static void Print(Stat s)
    {
        Debug.Log(s.Name + ": " + s.BaseValue);
    }

}
