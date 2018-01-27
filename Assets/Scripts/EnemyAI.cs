using UnityEngine;
using System.Collections;

public class EnemyAI: MonoBehaviour
{

     UnityEngine.AI.NavMeshAgent agent;
    Vector3 v3 = new Vector3(0, 1f, 0);

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
      
    }

    void Update()
    {
        agent.SetDestination(v3);
    }
}