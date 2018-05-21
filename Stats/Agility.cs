namespace Stats
{
    public class Agility : Stat
    {
        public Agility(int baseValue) : base(baseValue)
        {
            Name = "Agility";
            Description = "How fast you move?";
            ModifiedValue = 0;
            Type = StatType.Agility;
        }
    }
}
