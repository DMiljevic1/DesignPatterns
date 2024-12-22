using DesignPattern.DecoratorPattern.Components;

namespace DesignPattern.DecoratorPattern.Decorators;

public class Helmet : CharacterDecorator
{
    public Helmet(ICharacter character) : base(character)
    {
    }

    public override int GetAttack()
    {
        return base.GetAttack() + 5;
    }

    public override int GetDefense()
    {
        return base.GetDefense() + 5;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + " Character is wearing a helmet.";
    }
}
