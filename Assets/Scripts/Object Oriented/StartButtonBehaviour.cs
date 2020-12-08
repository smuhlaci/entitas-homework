using UnityEngine;

public class StartButtonBehaviour : MonoBehaviour
{
    public void ButtonPressed()
    {
        Contexts.sharedInstance.game.CreateEntity().isStartGame = true;;

         // Contexts.sharedInstance.game.CreateEntity().isStartGame = true;
        
        gameObject.SetActive(false);
    }
}
