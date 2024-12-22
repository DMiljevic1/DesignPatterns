using DesignPattern.CommandPattern.Commands;
using DesignPattern.CommandPattern.Invokers;
using DesignPattern.CommandPattern.Receivers;

namespace DesignPattern.CommandPattern;

public class Program
{
    public static void Main(string[] args)
    {
        var player = new Player();
        var inputHandler = new InputHandler();

        ICommand attack = new AttackCommand(player);
        ICommand defend = new DefendCommand(player);
        ICommand ability = new AbilityCommand(player);

        inputHandler.SetCommand(attack);
        inputHandler.ExecuteCommand();
        inputHandler.UndoCommand();

        inputHandler.SetCommand(defend);
        inputHandler.ExecuteCommand();
        inputHandler.UndoCommand();

        inputHandler.SetCommand(ability);
        inputHandler.ExecuteCommand();
        inputHandler.UndoCommand();
    }
}