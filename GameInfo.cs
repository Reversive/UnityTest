using Character_Classes;

public class GameInfo
{

    public Character LocalPlayer { get; set; }
    private static GameInfo instance = new GameInfo();

    private GameInfo(){}

    public static GameInfo GetInstance() { return instance; }

}