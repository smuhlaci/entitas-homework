using Entitas;
using UnityEngine;

public sealed class MoveSystem : IExecuteSystem
{
    private readonly Contexts _contexts;
    private readonly IGroup<GameEntity> _movableEntities;

    public MoveSystem(Contexts contexts)
    {
        _contexts = contexts;
        _movableEntities = contexts.game.GetGroup(GameMatcher.Movable);
    }

    public void Execute()
    {
        foreach (var movableEntity in _movableEntities)
        {
            movableEntity.position.x += movableEntity.speed.value * movableEntity.rotation.x * Time.deltaTime;
            movableEntity.position.y += movableEntity.speed.value * movableEntity.rotation.y * Time.deltaTime;
        }
    }
}
