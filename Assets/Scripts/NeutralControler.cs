using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    [SerializeField] GameObject neutralChar;
    private Transform playerPos;
    private Transform agentPos;
    int index = 1;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = player.GetComponent<Transform>();
        agent = GetComponent<NavMeshAgent>();
        agentPos = neutralChar.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waypoint == null)
        {
            waypoint = waypoints[index];
            index++;
        }
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
