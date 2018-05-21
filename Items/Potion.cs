namespace Items
{
    public class Potion : Item
    {
        public int SpellEffectId { get; set; }
        public PotionType EType { get; set; }

        public enum PotionType
        {
            Agility,
            Magicka,
            Strength
        }

        public Potion()
        {
            IType = ItemType.Potion;
        }
    }
}