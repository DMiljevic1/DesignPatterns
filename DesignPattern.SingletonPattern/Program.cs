using DesignPattern.SingletonPattern.Managers;

namespace DesignPattern.SingletonPattern;

public class Program
{
    public static void Main(string[] args)
    {
        GameSaveManager.GetInstance().Load();

        GameSaveManager.GetInstance().Save("Level 7 - Hitman: Absolution");

        GameSaveManager.GetInstance().Load();
    }
}