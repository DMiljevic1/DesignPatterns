namespace DesignPattern.ProxyPattern.Models;

public class NpcProxy : INpc
{
    private readonly string _name;
    private Npc? _npc;

    public NpcProxy(string name)
    {
        _name = name;
    }

    public string GetDetails()
    {
        return (_npc ??= new Npc(_name)).GetDetails();
    }

    public string GetName()
    {
        return _name;
    }
}
