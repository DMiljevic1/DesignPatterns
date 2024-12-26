using DesignPattern.TemplateMethodPattern.Base;

namespace DesignPattern.TemplateMethodPattern.Levels;

public class ForestLevel : GameLevel
{
    protected override void LoadResources()
    {
        Console.WriteLine("Loading forest textures and sounds...");
    }

    protected override void SpawnEnemies()
    {
        Console.WriteLine("Spawning wolves and bears...");
    }

    protected override void SetObjectives()
    {
        Console.WriteLine("Rescue the villagers trapped in the forest.");
    }

    protected override bool ShouldPlayCutscene()
    {
        return true;
    }

    protected override void PlayCutscene()
    {
        Console.WriteLine("Playing forest intro cutscene with mysterious music...");
    }
}
