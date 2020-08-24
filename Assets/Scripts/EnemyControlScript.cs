using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyControlScript : MonoBehaviour
{
    public float moveSpeed;
    private NavMeshAgent agent;
    private bool active = false;
    public Player player;
    private float timer = 0f;
    public Canvas gameOver;
    private float timeToKill;

    public Vector3 firstWayPoint;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (this.transform.position == firstWayPoint && !active)
        {
            active = true;
            moveSpeed /= 2;
        }
        if (active)
        {
            agent.SetDestination(player.transform.position);
        }

        if (Vector3.Distance(this.gameObject.transform.position, player.transform.position) < 15)
        {
            if (timeToKill == 0)
            {
                timeToKill = timer + 5;
            }
            this.gameObject.transform.position = (player.transform.position + (player.transform.forward * 5));
            if (timeToKill < timer)
            {
                gameOver.gameObject.SetActive(true);
                player.GetComponent<PlayerMovement>().enabled = false;
                player.GetComponentInChildren<CameraControl>().enabled = false;
            }
        }
    }
    public void Activation()
    {
        agent.SetDestination(firstWayPoint);
    }
}
