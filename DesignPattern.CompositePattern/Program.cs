using DesignPattern.CompositePattern.Composites;
using DesignPattern.CompositePattern.Leaves;

namespace DesignPattern.CompositePattern;

public class Program
{
    public static void Main(string[] args)
    {
        Item sword = new Item("Sword");
        Item helmet = new Item("Helmet");
        Item potion = new Item("Potion");

        Container chest = new Container("Chest");
        Container backpack = new Container("Backpack");

        chest.AddItem(sword);
        chest.AddItem(helmet);
        backpack.AddItem(potion);

        Container mainInventory = new Container("Main Inventory");
        mainInventory.AddItem(chest);
        mainInventory.AddItem(backpack);

        mainInventory.Display();
    }
}