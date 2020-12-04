using System.Collections.Generic;
using Entitas;
using UnityEngine;

public sealed class AddViewSystem : ReactiveSystem<GameEntity>
{
    public AddViewSystem(Contexts contexts) : base(contexts.game)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Asset.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return !entity.hasView;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var entity in entities)
        {
            entity.AddView(instantiateView(entity));
        }

        IView instantiateView(GameEntity entity)
        {
            var prefab = Resources.Load<GameObject>(entity.asset.value);
            var view = Object.Instantiate(prefab).GetComponent<IView>();

            view.Link(entity);

            return view;
        }
    }
}
