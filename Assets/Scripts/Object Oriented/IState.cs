using System.Collections;

namespace ObjectOriented
{
    public interface IState
    {
        bool IsActive { get; }
        IEnumerator Enter();
        IEnumerator Exit();
    }
}
