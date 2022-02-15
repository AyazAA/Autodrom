using System;
using UnityEngine;

public class CarCollisions : MonoBehaviour
{
    public event Action CarCollidedConeEvent;
    private MeshCollider _meshCollider;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<MeshCollider>(out _meshCollider))
        {
            CarCollidedConeEvent?.Invoke();
        }
    }
}
