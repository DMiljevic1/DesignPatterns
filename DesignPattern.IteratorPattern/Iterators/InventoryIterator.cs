using DesignPattern.IteratorPattern.Interfaces;
using DesignPattern.IteratorPattern.Models;

namespace DesignPattern.IteratorPattern.Iterators;

public class InventoryIterator : IIterator<Item>
{
    private List<Item> _items;
    private int _position = 0;

    public InventoryIterator(List<Item> items)
    {
        _items = items;        
    }

    public bool HasNext()
    {
        return _position < _items.Count;
    }

    public Item Next()
    {
        return _items[_position++];
    }
}
