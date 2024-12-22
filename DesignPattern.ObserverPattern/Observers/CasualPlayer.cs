using System.Xml.Linq;

namespace DesignPattern.ObserverPattern.Observers;

public class CasualPlayer : IPlayer
{
    private string _name;

    public CasualPlayer(string name)
    {
        _name = name;
    }
    public void Update(string patchNotes)
    {
        Console.WriteLine($"[Casual Player: {_name}] Checking out the new patch notes: {patchNotes}");
    }
}
