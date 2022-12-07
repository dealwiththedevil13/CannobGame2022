using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
   public Rigidbody rb;
   public int speed =50;

   void Start()
   {
      rb.velocity = Vector3.up * speed;
   }
}
