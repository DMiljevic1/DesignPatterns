namespace DesignPattern.TemplateMethodPattern.Base;

public abstract class GameLevel
{
    public void LoadLevel()
    {
        LoadResources();
        SpawnEnemies();
        SetObjectives();
        if(ShouldPlayCutscene())
            PlayCutscene();

        StartLevel();
    }

    protected abstract void LoadResources();
    protected abstract void SpawnEnemies();
    protected abstract void SetObjectives();

    protected virtual bool ShouldPlayCutscene()
    {
        return false;
    }

    protected virtual void PlayCutscene()
    {
        Console.WriteLine("Playing default cutscene...");
    }

    protected void StartLevel()
    {
        Console.WriteLine("Level started!\n");
    }
}
