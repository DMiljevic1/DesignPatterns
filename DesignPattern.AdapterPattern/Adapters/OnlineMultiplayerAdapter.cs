using DesignPattern.AdapterPattern.Adaptees;
using DesignPattern.AdapterPattern.Interfaces;

namespace DesignPattern.AdapterPattern.Adapters;

public class OnlineMultiplayerAdapter : IMultiplayer
{
    private readonly OnlineMultiplayer _onlineMultiplayer;

    public OnlineMultiplayerAdapter(OnlineMultiplayer onlineMultiplayer)
    {
        _onlineMultiplayer = onlineMultiplayer;
        _onlineMultiplayer.ConnectToServer("192.168.8.1");
    }
    public string GetData()
    {
        return _onlineMultiplayer.GetDataOnline();
    }

    public void SendData(string data)
    {
        _onlineMultiplayer.SendDataOnline(data);
    }
}
