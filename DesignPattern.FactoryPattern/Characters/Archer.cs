namespace DesignPattern.FactoryPattern.Characters;

public class Archer : ICharacter
{
    public void DisplayInfo()
    {
        Console.WriteLine("Archer class is class with high damage and mid defense. It has range attack and can put traps.");
    }
}
