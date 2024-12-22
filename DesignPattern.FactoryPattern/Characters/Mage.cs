namespace DesignPattern.FactoryPattern.Characters;

public class Mage : ICharacter
{
    public void DisplayInfo()
    {
        Console.WriteLine("Mage class is a class that has super high damage but very low defense. It has range attack and it's speed is low.");
    }
}
