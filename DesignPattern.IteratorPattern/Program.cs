using DesignPattern.IteratorPattern.Aggregates;
using DesignPattern.IteratorPattern.Interfaces;
using DesignPattern.IteratorPattern.Models;

namespace DesignPattern.IteratorPattern;

public class Program
{
    public static void Main(string[] args)
    {
        PlayerInventory inventory = new();
        inventory.AddItem(new Item("Sword"));
        inventory.AddItem(new Item("Food"));
        inventory.AddItem(new Item("Potion"));

        IIterator<Item> iterator = inventory.CreateIterator();
        while(iterator.HasNext())
        {
            Console.WriteLine(iterator.Next().Name);
        }
    }
}