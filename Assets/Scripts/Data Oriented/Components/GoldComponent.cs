using Entitas;
using Entitas.CodeGeneration.Attributes;

[Unique, Event(EventTarget.Self)]
public sealed class GoldComponent : IComponent
{
    public int value;
}
  