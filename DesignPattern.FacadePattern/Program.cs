using DesignPattern.FacadePattern.Facades;
using DesignPattern.FacadePattern.Systems;

namespace DesignPattern.FacadePattern;

public class Program
{
    public static void Main(string[] args)
    {
        var assetLoaderManager = new AssetLoaderManager();
        var networkManager = new NetworkManager();
        var userManager = new UserManager();

        var gameFacade = new GameFacade(assetLoaderManager, networkManager, userManager);

        gameFacade.StartGame();
    }
}