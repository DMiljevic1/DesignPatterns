using DesignPattern.DecoratorPattern.Components;

namespace DesignPattern.DecoratorPattern.Decorators;

public class SwordAndShield : CharacterDecorator
{
    public SwordAndShield(ICharacter character) : base(character)
    {
    }

    public override int GetAttack()
    {
        return base.GetAttack() + 15;
    }

    public override int GetDefense()
    {
        return base.GetDefense() + 20;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + " Character is wielding Sword and Shield.";
    }
}
