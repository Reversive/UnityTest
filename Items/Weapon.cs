namespace Items
{
    public class Weapon : Item
    {
        public int SpellEffectId { get; set; }
        public WeaponType WType { get; set; }

        public enum WeaponType
        {
            Sword,
            Bow,
            Staff
        }

        public Weapon()
        {
            IType = ItemType.Weapon;
        }
    }
}