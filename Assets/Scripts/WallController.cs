using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WallController : MonoBehaviour
{
    private NavMeshObstacle obstacle;
    // Start is called before the first frame update
    void Start()
    {
        obstacle = gameObject.AddComponent<NavMeshObstacle>();
        obstacle.shape = NavMeshObstacleShape.Capsule;
        obstacle.center = Vector3.up;
        obstacle.height = 2f;
        obstacle.carving = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
