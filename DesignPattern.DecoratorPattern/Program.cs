using DesignPattern.DecoratorPattern.Components;
using DesignPattern.DecoratorPattern.Decorators;

namespace DesignPattern.DecoratorPattern;

public class Program
{
    public static void Main(string[] args)
    {
        ICharacter character1 = new Warrior();
        ICharacter character2 = new Mage();

        character1 = new Cloak(character1);
        character1 = new Helmet(character1);
        character1 = new SwordAndShield(character1);

        Console.WriteLine($"\n Character1: Attack damage: {character1.GetAttack()}, Defense: {character1.GetDefense()}, Description: {character1.GetDescription()}");

        character2 = new Cloak(character2);
        character2 = new Helmet(character2);
        character2 = new Staff(character2);

        Console.WriteLine($"\n Character2: Attack damage: {character2.GetAttack()}, Defense: {character2.GetDefense()}, Description: {character2.GetDescription()}");
    }
}
