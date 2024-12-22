using DesignPattern.CommandPattern.Receivers;

namespace DesignPattern.CommandPattern.Commands;

public class AbilityCommand : ICommand
{
    private readonly Player _player;

    public AbilityCommand(Player player)
    {
        _player = player;
    }

    public void Execute()
    {
        _player.UseAbility();
    }

    public void Undo()
    {
        Console.WriteLine("Undo ability!");
    }
}
