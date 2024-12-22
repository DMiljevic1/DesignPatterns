namespace DesignPattern.SingletonPattern.Managers;

public class GameSaveManager
{
    private static readonly GameSaveManager _instance = new GameSaveManager();

    private GameSaveManager() { }

    public static GameSaveManager GetInstance()
    {
        return _instance;
    }

    public string SaveData { get; set; }
    public void Save(string data)
    {
        SaveData = data;
        Console.WriteLine($"Game Saved: {SaveData}");
    }

    public string Load()
    {
        if(String.IsNullOrWhiteSpace(SaveData))
            Console.WriteLine("No saved data!");
        else
            Console.WriteLine($"Game Loaded: {SaveData}");
        return SaveData;
    }
}
