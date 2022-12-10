using System;
using UnityEngine;
//Script by Education Public https://www.youtube.com/watch?v=5AsON1__quw&list=PL-ptF2slHtJBPrCYJRkATzjyxmcUuIL5D&index=8
public class CollisionBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "")
        {
            return;
        }
        Destroy(other.gameObject);
        Destroy(gameObject);

    }
}
