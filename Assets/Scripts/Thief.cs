using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Thief : MonoBehaviour
{
    [SerializeField] private UnityEvent _thiefDoorBreak;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Door door))
        {
            _thiefDoorBreak?.Invoke();
        }
    }
}
