namespace DesignPattern.CommandPattern.Commands;

public interface ICommand
{
    void Execute();
    void Undo();
}
