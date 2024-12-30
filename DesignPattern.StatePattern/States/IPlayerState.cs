namespace DesignPattern.StatePattern.States;

public interface IPlayerState
{
    void HandleInput(Player player, string action);
    void Update(Player player);
}
