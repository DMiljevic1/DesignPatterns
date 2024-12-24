using DesignPattern.FacadePattern.Systems;

namespace DesignPattern.FacadePattern.Facades;

public class GameFacade
{
    private readonly AssetLoaderManager _assetLoaderManager;
    private readonly NetworkManager _networkManager;
    private readonly UserManager _userManager;

    public GameFacade(AssetLoaderManager assetLoaderManager, NetworkManager networkManager, UserManager userManager)
    {
        _assetLoaderManager = assetLoaderManager;
        _networkManager = networkManager;
        _userManager = userManager;
    }

    public void StartGame()
    {
        _assetLoaderManager.LoadMap();
        _assetLoaderManager.LoadSounds();
        _assetLoaderManager.LoadModels();

        _networkManager.ConnectToServer();
        _networkManager.SyncPlayerData();

        _userManager.AuthenticateUser();
        _userManager.LoadUserProfile();
    }
}
