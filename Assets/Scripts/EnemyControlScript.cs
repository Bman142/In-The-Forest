using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyControlScript : MonoBehaviour
{
    public float moveSpeed;
    private NavMeshAgent agent;
    private bool active = false;
    public Player player;

    public Vector3 firstWayPoint;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position == firstWayPoint)
        {
            active = true;
            moveSpeed /= 2;
        }
        if (active)
        {
            agent.SetDestination(player.transform.position);
        }
    }
    public void Activation()
    {
        agent.SetDestination(firstWayPoint);
    }
}
