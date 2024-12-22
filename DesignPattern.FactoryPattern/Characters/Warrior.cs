namespace DesignPattern.FactoryPattern.Characters;

public class Warrior : ICharacter
{
    public void DisplayInfo()
    {
        Console.WriteLine("Warrior class is a class that has mid attack and high defense. His attack may deal low damage but it's very hard to kill.");
    }
}
