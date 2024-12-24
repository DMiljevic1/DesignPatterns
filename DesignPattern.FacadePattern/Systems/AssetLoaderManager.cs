namespace DesignPattern.FacadePattern.Systems;

public class AssetLoaderManager
{
    public void LoadMap() => Console.WriteLine("Loading map...");
    public void LoadModels() => Console.WriteLine("Loading 3D models...");
    public void LoadSounds() => Console.WriteLine("Loading sound effects...");
}
