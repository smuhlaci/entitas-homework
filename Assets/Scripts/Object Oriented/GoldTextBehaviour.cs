using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class GoldTextBehaviour : MonoBehaviour, IGoldListener
{
    private TextMeshProUGUI text;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        Contexts.sharedInstance.game.goldEntity.AddGoldListener(this);
    }

    private void OnDisable()
    {
        Contexts.sharedInstance.game.goldEntity.RemoveGoldListener(this);
    }

    public void OnGold(GameEntity entity, int value)
    {
        text.text = value.ToString();
    }
}
