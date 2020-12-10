using Entitas;

public class InitializeGameSystem : IInitializeSystem
{
    private readonly Contexts _contexts;

    public InitializeGameSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Initialize()
    {
        _contexts.game.SetBulletSpeed(3F);
        
        var playerEntity = _contexts.game.CreatePlayer();
        _contexts.game.CreateWeapon(playerEntity, 0F);
        _contexts.game.CreateWeapon(playerEntity, 45F);
        _contexts.game.CreateWeapon(playerEntity, -45F);
    }
}
