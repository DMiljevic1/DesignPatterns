using DesignPattern.DecoratorPattern.Components;

namespace DesignPattern.DecoratorPattern.Decorators;

public class Cloak : CharacterDecorator
{
    public Cloak(ICharacter character) : base(character)
    {
    }

    public override int GetAttack()
    {
        return base.GetAttack() + 10;
    }

    public override int GetDefense() 
    { 
        return base.GetDefense() + 10; 
    }

    public override string GetDescription()
    {
        return base.GetDescription() + " Character is wearing a cloak.";
    }
}
