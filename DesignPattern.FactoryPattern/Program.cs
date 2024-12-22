using DesignPattern.FactoryPattern.Characters;
using DesignPattern.FactoryPattern.Enums;
using DesignPattern.FactoryPattern.Factories;

namespace DesignPattern.FactoryPattern;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose a character: Warrior, Mage, Archer");

        if (Enum.TryParse<CharacterType>(Console.ReadLine(), true, out CharacterType type))
        {
            ICharacter character = CharacterFactory.CreateCharacter(type);
            character.DisplayInfo();
        }
        else
        {
            Console.WriteLine("Invalid character type.");
        }

    }
}