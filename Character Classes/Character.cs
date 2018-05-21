using System.Collections.Generic;
using Stats;

namespace Character_Classes
{
	public class Character {

		public string Name { get; set; }
		public string Description { get; set; }
		public int Level { get; set; }
		public int Gold { get; set; }
		public List<Stat> Stats { get; set; }
		public ICharacterType Type { get; private set; }
		public Inventory Inventory { get; set; }
		
		public Character(ICharacterType characterType)
		{
			Type = characterType;
		}
	}
}
