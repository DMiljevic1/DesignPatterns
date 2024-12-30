namespace DesignPattern.StatePattern;

public class Program
{
    public static void Main(string[] args)
    {
        var player = new Player();

        player.Update();
        player.HandleInput("run");
        player.Update();
        player.HandleInput("jump");
        player.Update();
        player.HandleInput("land");
        player.Update();
        player.HandleInput("fight");
        player.Update();
        player.HandleInput("stop");
        player.Update();
    }
}