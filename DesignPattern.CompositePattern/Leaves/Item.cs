using DesignPattern.CompositePattern.Components;

namespace DesignPattern.CompositePattern.Leaves;

public class Item : IGameComponent
{
    public string Name { get; }

    public Item(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine($"Item: {Name}");
    }
}
