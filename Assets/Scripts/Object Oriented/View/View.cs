using Entitas.Unity;
using UnityEngine;

public class View : MonoBehaviour, IView, IDestroyedListener
{
    public GameEntity entity;
    
    public virtual void Link(GameEntity entity)
    {
        gameObject.Link(entity);
        transform.position = new Vector3(entity.position.x, entity.position.y, 0F);
        entity.AddDestroyedListener(this);

        this.entity = entity;
    }

    public virtual void OnDestroyed(GameEntity entity)
    {
        DestroyObject();
    }

    protected virtual void DestroyObject()
    {
        GameObject o;
        (o = gameObject).Unlink();
        Destroy(o);
    }
}
