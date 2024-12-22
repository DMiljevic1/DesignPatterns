using DesignPattern.CommandPattern.Commands;

namespace DesignPattern.CommandPattern.Invokers;

public class InputHandler
{
    private ICommand? _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        _command?.Execute();
    }

    public void UndoCommand()
    {
        _command?.Undo();
    }
}
