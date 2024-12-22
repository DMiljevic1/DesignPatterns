using DesignPattern.DecoratorPattern.Components;

namespace DesignPattern.DecoratorPattern.Decorators;

public class Staff : CharacterDecorator
{
    public Staff(ICharacter character) : base(character)
    {
    }

    public override int GetAttack()
    {
        return base.GetAttack() + 40;
    }

    public override int GetDefense()
    {
        return base.GetDefense();
    }

    public override string GetDescription()
    {
        return base.GetDescription() + " Character is wielding a Staff.";
    }
}
