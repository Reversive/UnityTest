namespace Stats
{
    public class Magicka : Stat
    {
        public Magicka(int baseValue) : base(baseValue)
        {
            Name = "Magicka";
            Description = "How are your spells and mana?";
            ModifiedValue = 0;
            Type = StatType.Magicka;
        }
    }
}
