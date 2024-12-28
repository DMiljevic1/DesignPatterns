using DesignPattern.CompositePattern.Components;
using System.Xml.Linq;

namespace DesignPattern.CompositePattern.Composites;

public class Container : IGameComponent
{
    private readonly List<IGameComponent> _components = new List<IGameComponent>();
    public string Name { get; }

    public Container(string name)
    {
        Name = name;
    }

    public void AddItem(IGameComponent component)
    {
        _components.Add(component);
    }

    public void RemoveItem(IGameComponent component)
    {
        _components.Remove(component);
    }

    public void Display()
    {
        Console.WriteLine($"Container: {Name}");
        foreach (var component in _components)
        {
            component.Display();
        }
    }
}
