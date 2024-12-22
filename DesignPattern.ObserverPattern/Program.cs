using DesignPattern.ObserverPattern.Observers;
using DesignPattern.ObserverPattern.Subjects;

namespace DesignPattern.ObserverPattern;

public class Program
{
    public static void Main(string[] args)
    {
        var player1 = new CasualPlayer("David");
        var player2 = new CompetitivePlayer("Duje");

        var gameServer = new GameServer();
        gameServer.RegisterPlayer(player1);
        gameServer.RegisterPlayer(player2);
        gameServer.ReleasePatch("New skins for the game");
    }
}
