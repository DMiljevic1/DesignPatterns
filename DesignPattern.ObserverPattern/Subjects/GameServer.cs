using DesignPattern.ObserverPattern.Observers;

namespace DesignPattern.ObserverPattern.Subjects;

public class GameServer : IGameServer
{
    private List<IPlayer> players = new();
    private string patchNotes = String.Empty;
    public void NotifyPlayers()
    {
        foreach (var player in players)
        {
            player.Update(patchNotes);
        }
    }

    public void RegisterPlayer(IPlayer player)
    {
        players.Add(player);
    }

    public void RemovePlayer(IPlayer player)
    {
        players.Remove(player);
    }

    public void ReleasePatch(string patchNotes)
    {
        this.patchNotes = patchNotes;
        Console.WriteLine("\n[Server] New Patch Released: " + patchNotes);
        NotifyPlayers();
    }
}
