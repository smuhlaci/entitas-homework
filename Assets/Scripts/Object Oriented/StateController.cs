using System.Collections;
using UnityEngine;

namespace ObjectOriented
{
    public class StateController : MonoBehaviour
    {
        #region STATIC DEFINITIONS
        
        private static StateController _instance;

        public static void ChangeState(State state)
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<StateController>();
            }

            _instance.StartCoroutine(_instance.ChangeStateTransition(state));
        }
        
        #endregion

        #region INSPECTOR REFERENCES

        [SerializeField] private MenuState menuState;
        [SerializeField] private GameState gameState;
        #endregion
        
        private IState _currentState;

        private void Start()
        {
            ChangeState(State.Menu);
        }
        
        private IEnumerator ChangeStateTransition(State state)
        {
            if (_currentState != null)
            {
                yield return StartCoroutine(_currentState.Exit());
                ((MonoBehaviour) _currentState).gameObject.SetActive(false);
            }

            
            switch (state)
            {
                case State.Menu:
                    _currentState = menuState;
                    break;
                case State.Game:
                    _currentState = gameState;
                    break;
            }
            
            ((MonoBehaviour) _currentState).gameObject.SetActive(true);
            yield return StartCoroutine(_currentState.Enter());
        }
    }
    
    public enum State
    {
        Menu,
        Game
    }
}
