using DesignPattern.AdapterPattern.Adaptees;
using DesignPattern.AdapterPattern.Adapters;
using DesignPattern.AdapterPattern.Interfaces;

namespace DesignPattern.AdapterPattern;

public class Program
{
    public static void Main(string[] args)
    {
        IMultiplayer localMultiplayer = new LocalMultiplayer();
        localMultiplayer.SendData("Local gaming is great!");
        localMultiplayer.GetData();

        OnlineMultiplayer onlineMultiplayer = new OnlineMultiplayer();
        IMultiplayer onlineMultiplayerAdapter = new OnlineMultiplayerAdapter(onlineMultiplayer);
        onlineMultiplayerAdapter.SendData("Online gaming in better!");
        onlineMultiplayerAdapter.GetData();
    }
}