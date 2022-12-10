using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    

    // Code from The Ultimate Developer https://www.youtube.com/watch?v=0uQrpQXiGEs

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
   void Update()
   {
       rb.velocity = new Vector3(0f, -speed);
   }

    /*private void OnTriggerEnter(Collider other)
    {
        object collision;
       if (other.CompareTag("Boundary"))
        {
            moveSpeed *= -1;
        }
    }*/
}
