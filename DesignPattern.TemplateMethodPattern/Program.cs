using DesignPattern.TemplateMethodPattern.Base;
using DesignPattern.TemplateMethodPattern.Levels;

namespace DesignPattern.TemplateMethodPattern;

public class Program
{
    public static void Main(string[] args)
    {
        GameLevel dungeon = new DungeonLevel();
        dungeon.LoadLevel();

        GameLevel forest = new ForestLevel();
        forest.LoadLevel();
    }
}