using System.Xml.Linq;

namespace DesignPattern.ObserverPattern.Observers;

public class CompetitivePlayer : IPlayer
{
    private string _name;
    public CompetitivePlayer(string name)
    {
        _name = name;
    }

    public void Update(string patchNotes)
    {
        Console.WriteLine($"[Competitive Player: {_name}] Checking out the new patch notes: {patchNotes}");
    }
}
