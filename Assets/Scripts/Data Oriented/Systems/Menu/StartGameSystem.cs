using System.Collections.Generic;
using Entitas;
using ObjectOriented;

public sealed class StartGameSystem : ReactiveSystem<GameEntity>
{
    public StartGameSystem(Contexts contexts) : base(contexts.game)
    {
        
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.StartGame.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> updatedEntities)
    {
        StateController.ChangeState(State.Game);
    }
}
