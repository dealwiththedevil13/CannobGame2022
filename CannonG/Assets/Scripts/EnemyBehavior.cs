using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float moveSpeed;
    void Start()
    {
        
    }

    // Code from Night Run Studio https://www.youtube.com/watch?v=G3OKV1fcsGk

    void Update()
    {
            transform.Translate(Vector2.right * (moveSpeed * Time.deltaTime));
    }
    
   /* private IEnumerator OnTriggerEnter(Collider other)
    {
        
    }*/

    private void OnTriggerEnter(Collider other)
    {
        object collision;
        if (Collision.gameObject.tag == "Boundary")
        {
            moveSpeed *= -1;
        }
    }
}
