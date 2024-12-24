using DesignPattern.AdapterPattern.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPattern.AdapterPattern.Adaptees;

public class LocalMultiplayer : IMultiplayer
{
    public string GetData()
    {
        Console.WriteLine("[Local] Receiving Data...");
        return "Local Data";
    }

    public void SendData(string data)
    {
        Console.WriteLine($"[Local] Sending Data: {data}");
    }
}
