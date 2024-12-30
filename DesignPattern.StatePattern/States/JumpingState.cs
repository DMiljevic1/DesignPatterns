namespace DesignPattern.StatePattern.States;

public class JumpingState : IPlayerState
{
    public void HandleInput(Player player, string action)
    {
        if (action == "land")
            player.SetState(new IdleState());
    }

    public void Update(Player player)
    {
        Console.WriteLine("Player is jumping.");
    }
}
