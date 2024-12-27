using DesignPattern.IteratorPattern.Models;

namespace DesignPattern.IteratorPattern.Interfaces;

public interface IInventory
{
    IIterator<Item> CreateIterator();
}
