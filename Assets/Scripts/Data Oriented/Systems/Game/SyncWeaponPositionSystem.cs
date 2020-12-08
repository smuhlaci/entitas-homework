using Entitas;

public sealed class SyncWeaponPositionSystem : IExecuteSystem
{
    private readonly Contexts _contexts;
    private readonly IGroup<GameEntity> _weapons;
    private readonly IGroup<GameEntity> _players;

    public SyncWeaponPositionSystem(Contexts contexts)
    {
        _contexts = contexts;
        _weapons = _contexts.game.GetGroup(GameMatcher.Weapon);
        _players = _contexts.game.GetGroup(GameMatcher.Player);
    }

    public void Execute()
    {
        foreach (var weaponEntity in _weapons)
        {
            
        }
    }
}
