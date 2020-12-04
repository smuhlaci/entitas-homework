using Entitas;

public sealed class CheckCompletedTimersSystem : IExecuteSystem
{
    private readonly IGroup<GameEntity> _timerPassedTimes;

    public CheckCompletedTimersSystem(Contexts contexts)
    {
        _timerPassedTimes = contexts.game.GetGroup(GameMatcher.TimerPassedTime);
    }

    public void Execute()
    {
        foreach (var entity in _timerPassedTimes.GetEntities())
        {
            if (entity.timerPassedTime.value >= entity.timerTick.value)
            {
                entity.RemoveTimerPassedTime();
            }
        }
    }
}
