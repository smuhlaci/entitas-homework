using System.Collections;
using UnityEngine;

namespace ObjectOriented
{
    public class MenuState : MonoBehaviour, IState
    {
        public bool IsActive { get; private set; }
        private Entitas.Systems _systems;
        
        private void OnEnable()
        {
            _systems = new MenuSystems(Contexts.sharedInstance);
            _systems.Initialize();
        }

        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }

        private void OnDisable()
        {
            _systems.TearDown();
            _systems.DeactivateReactiveSystems();
            _systems.ClearReactiveSystems();

            _systems = null;
        }
        
        public IEnumerator Enter()
        {
            IsActive = true;
            yield break;
        }

        public IEnumerator Exit()
        {
            IsActive = false;
            yield break;
        }
    }
}
