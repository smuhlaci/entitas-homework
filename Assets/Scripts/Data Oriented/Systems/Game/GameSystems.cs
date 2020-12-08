public sealed class GameSystems : Feature
{
    public GameSystems(Contexts contexts)
    {
        Add(new InitializeGameSystem(contexts));
        Add(new GameEventSystems(contexts));
        Add(new TimerSystems(contexts));
        Add(new ShootingSystem(contexts));
        Add(new MoveSystem(contexts));
        Add(new AddViewSystem(contexts));
        
        Add(new DestroyOldBulletsSystem(contexts));
    }
}
