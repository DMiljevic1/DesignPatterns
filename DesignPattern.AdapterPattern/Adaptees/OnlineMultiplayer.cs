using DesignPattern.AdapterPattern.Interfaces;

namespace DesignPattern.AdapterPattern.Adaptees;

public class OnlineMultiplayer
{
    public void ConnectToServer(string serverAddress)
    {
        Console.WriteLine($"[Online] Connected to server at: {serverAddress}");
    }

    public void SendDataOnline(string data)
    {
        Console.WriteLine($"[Online] Sending data: {data}");
    }

    public string GetDataOnline()
    {
        Console.WriteLine("[Online] Receiving data...");
        return "Online Data";
    }
}
