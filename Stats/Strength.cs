namespace Stats
{
    public class Strength : Stat
    {
        public Strength(int baseValue) : base(baseValue)
        {
            Name = "Strength";
            Description = "How strong are you?";
            ModifiedValue = 0;
            Type = StatType.Strength;
        }
    }
}
