namespace DesignPattern.ProxyPattern.Models;

public class Npc : INpc
{
    private readonly string _name;
    private readonly string _details;

    public Npc(string name)
    {
        _name = name;
        _details = LoadDetailsFromDatabase(name);
    }

    public string GetDetails()
    {
        return _details;
    }

    public string GetName()
    {
        return _name;
    }

    private string LoadDetailsFromDatabase(string npcName)
    {
        Console.WriteLine($"Loading details for {npcName}...");
        Thread.Sleep(2000); // Simulate delay
        return npcName switch
        {
            "Gandalf" => $"{npcName} is a powerful mage wielding a staff.",
            "Aragorn" => $"{npcName} is a skilled ranger and heir to the throne of Gondor.",
            "Legolas" => $"{npcName} is an elven archer with unmatched precision.",
            "Gimli" => $"{npcName} is a fearless dwarf warrior wielding an axe.",
            "Frodo" => $"{npcName} is a hobbit burdened with the One Ring.",
            _ => $"{npcName} is an unknown adventurer."
        };
    }
}
