using System.Collections.Generic;
using Stats;

namespace Character_Classes
{
    public class Warrior : ICharacterType
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public List<Stat> Stats { get; set; }

        public Warrior()
        {
            Name = "Warrior";
            Description = "Almighty warrior!";
            var aux = new List<Stat>();
            aux.AddRange(new List<Stat> {new Agility(5), new Magicka(5), new Strength(5)});
            Stats = aux;
        }
    }
}
