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
        return entity.isPlayer;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var playerEntity in entities)
        {
            _contexts.game.CreateBullet(playerEntity.position.x, playerEntity.position.y + 0.1F);
            
            if (playerEntity.hasTimerTick)
            {
                playerEntity.AddTimerPassedTime(0F);
            }
        }
    }
}
