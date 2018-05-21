using System.Collections.Generic;
using Items;

public class Inventory
{
    private const int Maxitems = 50;
    public Dictionary<Item, int> Items { get; private set; }

    
    public void Store(Item item)
    {
        if (!HasItem(item) && Items.Count < Maxitems)
        {
            Items.Add(item, 1);
        } else
        {
            Items[item]++;
        }
    }

    public bool HasItem(Item item)
    {
        if (Items.ContainsKey(item)) return true;
        return false;
    }

    public bool Take(Item item)
    {
        return Items.Remove(item);
    }

    public bool Take(Item item, int amount)
    {
        if (HasItem(item))
        {
            if (Items[item] - amount <= 0)
            {
                return Take(item);
            }

            Items[item] -= amount;
            return true;
        }

        return false;
    }

}