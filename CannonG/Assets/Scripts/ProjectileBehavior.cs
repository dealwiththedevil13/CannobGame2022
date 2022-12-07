using UnityEngine;

//Script reference by The Ultimate Developer at https://www.youtube.com/watch?v=X5kGAy5CPVs
public class ProjectileBehavior : MonoBehaviour
{
    public GameObject BulletPrefab;

    public void Fire()
    {
        GameObject bullet = Instantiate(BulletPrefab, this.transform.position, transform.rotation, transform);

        Destroy(bullet, 1.5f);
    }
}
