using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NeutralControler : MonoBehaviour
{
    [SerializeField] List<Transform> waypoints;
    private NavMeshAgent agent;
    [SerializeField] Transform waypoint;
    private Vector3 diffPos;
    private float dist;
    [SerializeField] GameObject player;
    private Transform playerPos;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = player.GetComponent<Transform>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        diffPos = this.transform.position - playerPos.position;
        dist = diffPos.magnitude;
        if (dist <= 3.0f)//close
        {
            agent.SetDestination(waypoint.position);
        }
        else if (dist > 3.0f && dist < 10.0f)//far
        {
            agent.SetDestination(playerPos.position);
        }
        else if (dist > 10.0f)
        {
            //have agent go to waypoint
            agent.SetDestination(waypoint.position);
        }
        
    }
}
