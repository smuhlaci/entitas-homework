using System.Collections.Generic;
using Entitas;

public sealed class ShootingSystem : ReactiveSystem<GameEntity>
{
    private readonly Contexts _contexts;

    public ShootingSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.TimerPassedTime.Removed());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.isWeapon;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var weaponEntity in entities)
        {
            _contexts.game.CreateBullet(weaponEntity);
            
            if (weaponEntity.hasTimerTick)
            {
                weaponEntity.AddTimerPassedTime(0F);
            }
        }
    }
}
