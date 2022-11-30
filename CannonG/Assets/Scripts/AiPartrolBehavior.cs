using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiPartrolBehavior : MonoBehaviour
{
    private NavMeshAgent Enemy;
    public List<Transform> Points;
    void Start()
    {
        i = 0;
        Enemy = GetComponent<NavMeshAgent>();
    }

    private int i = 0;
    
    void Update()
    {
        if (Enemy.pathPending || !(Enemy.remainingDistance < 0.5f)) return;
        Enemy.destination = Points[i].position;
        i = (i + 1) % Points.Count;
    }
}
