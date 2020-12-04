public sealed class TimerSystems : Feature
{
    public TimerSystems(Contexts contexts)
    {
        Add(new UpdateTimerSystem(contexts));
        Add(new CheckCompletedTimersSystem(contexts));
    }
}
