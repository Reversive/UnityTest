namespace Stats
{
    public class Stat
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int BaseValue { get; set; }
        public int ModifiedValue { get; set; }
        public StatType Type { get; set; }

        public Stat(int baseValue)
        {
            BaseValue = baseValue;
        }

        public enum StatType
        {
            Agility,
            Strength,
            Magicka,
        }
    }
}
