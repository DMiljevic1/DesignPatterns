namespace DesignPattern.FacadePattern.Systems;

public class NetworkManager
{
    public void ConnectToServer() => Console.WriteLine("Connecting to game server...");
    public void SyncPlayerData() => Console.WriteLine("Synchronizing player data...");
}
