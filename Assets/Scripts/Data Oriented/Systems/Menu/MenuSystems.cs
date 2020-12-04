public sealed class MenuSystems : Feature
{
    public MenuSystems(Contexts contexts)
    {
        Add(new StartGameSystem(contexts));
        Add(new GameEventSystems(contexts));
        Add(new TimerSystems(contexts));
    }
}
