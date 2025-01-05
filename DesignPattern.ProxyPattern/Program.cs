using DesignPattern.ProxyPattern.Models;

namespace DesignPattern.ProxyPattern;

public class Program
{
    public static void Main(string[] args)
    {
        INpc npc1 = new NpcProxy("Gandalf");
        INpc npc2 = new NpcProxy("Aragorn");

        Console.WriteLine(npc1.GetName());
        Console.WriteLine(npc1.GetDetails());
        Console.WriteLine(npc1.GetDetails());

        Console.WriteLine(npc2.GetName());
        Console.WriteLine(npc2.GetDetails());
        Console.WriteLine(npc2.GetDetails());
    }
}