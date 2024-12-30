namespace DesignPattern.StatePattern.States;

public class RunningState : IPlayerState
{
    public void HandleInput(Player player, string action)
    {
        if (action == "stop")
            player.SetState(new IdleState());
        else if (action == "jump")
            player.SetState(new JumpingState());
    }

    public void Update(Player player)
    {
        Console.WriteLine("Player is running.");
    }
}
