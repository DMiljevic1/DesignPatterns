namespace DesignPattern.CommandPattern.Receivers;

public class Player
{
    public void Attack()
    {
        Console.WriteLine("Player attacks!");
    }

    public void Defend()
    {
        Console.WriteLine("Player defends!");
    }

    public void UseAbility()
    {
        Console.WriteLine("Player uses an ability!");
    }
}
