using Entitas;
using UnityEngine;

public sealed class UpdateTimerSystem : IExecuteSystem
{
    private readonly IGroup<GameEntity> timers;

    public UpdateTimerSystem(Contexts contexts)
    {
        timers = contexts.game.GetGroup(GameMatcher.TimerPassedTime);
    }

    public void Execute()
    {
        foreach (var timer in timers)
        {
            timer.timerPassedTime.value += Time.deltaTime;
        }
    }
}
