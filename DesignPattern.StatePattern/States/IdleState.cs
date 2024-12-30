namespace DesignPattern.StatePattern.States;

public class IdleState : IPlayerState
{
    public void HandleInput(Player player, string action)
    {
        if (action == "run")
            player.SetState(new RunningState());
        else if (action == "jump")
            player.SetState(new JumpingState());
        else if (action == "fight")
            player.SetState(new FightingState());
    }

    public void Update(Player player)
    {
        Console.WriteLine("Player is standing still.");
    }
}
