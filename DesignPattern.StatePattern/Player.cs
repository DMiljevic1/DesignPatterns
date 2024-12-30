using DesignPattern.StatePattern.States;

namespace DesignPattern.StatePattern;

public class Player
{
    private IPlayerState _playerState;

    public Player()
    {
        _playerState = new IdleState();
    }

    public void SetState(IPlayerState playerState)
    {
        _playerState = playerState;
    }

    public void HandleInput(string action)
    {
        _playerState.HandleInput(this, action);
    }

    public void Update()
    {
        _playerState.Update(this);
    }
}
