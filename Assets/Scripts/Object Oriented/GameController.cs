using Entitas;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Contexts _contexts;

    private Systems _systems;
    
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    private void Start()
    {
        _contexts = Contexts.sharedInstance;
    }
}
