using System;
using Entitas;

public sealed class TimerComponent : IComponent
{
    public float tickSeconds;
    public float passedSeconds;
    public Action callback;
}
  