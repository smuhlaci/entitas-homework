using System.Collections.Generic;
using Entitas;

public sealed class DestroyOldBulletsSystem : ReactiveSystem<GameEntity>
{
    public DestroyOldBulletsSystem(Contexts contexts) : base(contexts.game)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.TimerPassedTime.Removed());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.isBullet;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            e.isDestroyed = true;
        }
    }
}
