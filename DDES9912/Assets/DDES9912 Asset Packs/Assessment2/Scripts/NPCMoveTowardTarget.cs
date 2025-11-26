using UnityEngine;
using UnityEngine.AI;
// Makes the NPC move toward a target point using NavMeshAgent

[RequireComponent(typeof(NavMeshAgent))]
public class NPCMoveTowardTarget : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform destination;
    public bool canMove = true; // Whether the NPC is allowed to move toward the target

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove) return;    // Stop updating movement when disabled

        if (agent != null && destination != null)
        {
            agent.SetDestination(destination.position);
        }
    }
}
