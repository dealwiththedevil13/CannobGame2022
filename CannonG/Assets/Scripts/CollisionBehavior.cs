using System;
using UnityEngine;

public class CollisionBehavior : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy");
        
    }
}
