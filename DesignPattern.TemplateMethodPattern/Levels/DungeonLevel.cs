using DesignPattern.TemplateMethodPattern.Base;

namespace DesignPattern.TemplateMethodPattern.Levels;

public class DungeonLevel : GameLevel
{
    protected override void LoadResources()
    {
        Console.WriteLine("Loading dungeon textures and sounds...");
    }

    protected override void SpawnEnemies()
    {
        Console.WriteLine("Spawning goblins and trolls...");
    }

    protected override void SetObjectives()
    {
        Console.WriteLine("Find the treasure and escape the dungeon.");
    }
}
