using System.Collections.Generic;
using Stats;

namespace Items
{
    public class Item {
    
        public int Id { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Stat> Stats { get; set; }
        public ItemType IType { get; set; }

        public enum ItemType
        {
            Weapon,
            Equipment,
            Potion
        }
        
        public override int GetHashCode()
        {
            if (Id == null) return 0;
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (!(obj is Item)) return false;
            return Id == ((Item) obj).Id;
        }
    }
}
