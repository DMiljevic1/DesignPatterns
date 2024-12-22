using DesignPattern.ObserverPattern.Observers;

namespace DesignPattern.ObserverPattern.Subjects;

public interface IGameServer
{
    void RegisterPlayer(IPlayer player);
    void RemovePlayer(IPlayer player);
    void NotifyPlayers();
}
