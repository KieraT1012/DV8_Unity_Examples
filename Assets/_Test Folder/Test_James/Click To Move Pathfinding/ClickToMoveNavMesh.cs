using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// whatever is being moved needs a rigidbody and a navmeshagent
[RequireComponent(typeof(NavMeshAgent), typeof(Rigidbody))]
public class ClickToMoveNavMesh : MonoBehaviour
{
    NavMeshAgent agent;
    [Range(1, 25)]
    public float MoveSpeed=10f;

    private void Awake()
    {
        // find and cache navmeshagent component
        agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        MoveSpeed = Random.Range(3f, 18f);    // remove this line to get rid of random speeds
        agent.speed = MoveSpeed;
    }

    void Update()
    {
        //update move speed if needed
        if (agent.speed != MoveSpeed) { agent.speed = MoveSpeed; }
        // if detect a LMB click
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            // do a raycast from screen to mousepointer and set hit as the object that was hit
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 500))
            {
                // set target destination to whatever was hit
                agent.destination = hit.point;
            }
        }
    }
}