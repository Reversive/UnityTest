using System.Collections.Generic;
using Stats;

namespace Character_Classes
{
    public interface ICharacterType
    {
        string Name { get; set; }
        string Description { get; set; }
        List<Stat> Stats { get; set; }
        
    }
}