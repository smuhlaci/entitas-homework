using System;
using UnityEngine;

[RequireComponent(typeof(View))]
public class BulletBehaviour : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Vector2 movement;
    private View _view;

    private void Awake()
    {
        _view = GetComponent<View>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var position = new Vector2(_view.entity.position.x, _view.entity.position.y);
        _rigidbody.MovePosition(position);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var otherEntity = other.gameObject.GetComponent<View>().entity;
        if (otherEntity.isPlayer == false && _view.entity.isBullet == false)
        {
            otherEntity.isDestroyed = true;
           _view.entity.isDestroyed = true;
        }
    }
}
