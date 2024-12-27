using DesignPattern.IteratorPattern.Interfaces;
using DesignPattern.IteratorPattern.Iterators;
using DesignPattern.IteratorPattern.Models;

namespace DesignPattern.IteratorPattern.Aggregates;

public class PlayerInventory : IInventory
{
    private List<Item> _items = new();

    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public IIterator<Item> CreateIterator()
    {
        return new InventoryIterator(_items);
    }
}
