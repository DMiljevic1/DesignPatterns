namespace DesignPattern.DecoratorPattern.Components;

public class Warrior : ICharacter
{   
    public int GetAttack()
    {
        return 20;
    }

    public int GetDefense()
    {
        return 20;
    }

    public string GetDescription()
    {
        return "Warror: Character who has solid attack and defense. Good in both but not the best in either.";
    }
}
