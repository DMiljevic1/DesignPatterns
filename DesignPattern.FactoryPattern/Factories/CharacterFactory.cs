using DesignPattern.FactoryPattern.Characters;
using DesignPattern.FactoryPattern.Enums;

namespace DesignPattern.FactoryPattern.Factories;

public static class CharacterFactory
{
    public static ICharacter CreateCharacter(CharacterType type)
    {
        return type switch
        {
            CharacterType.Warrior => new Warrior(),
            CharacterType.Mage => new Mage(),
            CharacterType.Archer => new Archer(),
            _ => throw new NotSupportedException($"Character type '{type.ToString()}' is not supported.")
        };
    }
}
