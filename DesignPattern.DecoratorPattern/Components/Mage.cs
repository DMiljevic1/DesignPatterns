namespace DesignPattern.DecoratorPattern.Components;

public class Mage : ICharacter
{
    public int GetAttack()
    {
        return 40;
    }

    public int GetDefense()
    {
        return 5;
    }

    public string GetDescription()
    {
        return "Mage: Character that is good in offense but bad in defense.";
    }
}
