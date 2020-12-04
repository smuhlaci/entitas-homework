using UnityEngine;

public class StartButtonBehaviour : MonoBehaviour
{
    private GameEntity _entity;

    public void ButtonPressed()
    {
        _entity = Contexts.sharedInstance.game.CreateEntity();

        _entity.isStartGame = true;
        
        gameObject.SetActive(false);
    }
}
