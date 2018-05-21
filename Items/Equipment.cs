namespace Items
{
    public class Equipment : Item
    {
        public int SpellEffectId { get; set; }
        public EquipmentType EType { get; set; }

        public enum EquipmentType
        {
            Head,
            Chest,
            Shoulders,
            Legs,
            Feet
        }

        public Equipment()
        {
            IType = ItemType.Equipment;
        }
    }
}