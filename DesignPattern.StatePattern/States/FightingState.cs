namespace DesignPattern.StatePattern.States;

public class FightingState : IPlayerState
{
    public void HandleInput(Player player, string action)
    {
        if (action == "stop")
            player.SetState(new IdleState());
    }

    public void Update(Player player)
    {
        Console.WriteLine("Player is fighting.");
    }
}
