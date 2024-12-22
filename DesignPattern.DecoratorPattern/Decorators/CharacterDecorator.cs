using DesignPattern.DecoratorPattern.Components;

namespace DesignPattern.DecoratorPattern.Decorators;

public class CharacterDecorator : ICharacter
{
    private readonly ICharacter _character;
    public CharacterDecorator(ICharacter character)
    {
        _character = character;
    }
    public virtual int GetAttack()
    {
        return _character.GetAttack();
    }

    public virtual int GetDefense()
    {
        return _character.GetDefense();
    }

    public virtual string GetDescription()
    {
        return _character.GetDescription();
    }
}
