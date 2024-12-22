using DesignPattern.CommandPattern.Receivers;

namespace DesignPattern.CommandPattern.Commands;

public class DefendCommand : ICommand
{
    private readonly Player _player;

    public DefendCommand(Player player)
    {
        _player = player;
    }

    public void Execute()
    {
        _player.Defend();
    }

    public void Undo()
    {
        Console.WriteLine("Undo defend!");
    }
}
