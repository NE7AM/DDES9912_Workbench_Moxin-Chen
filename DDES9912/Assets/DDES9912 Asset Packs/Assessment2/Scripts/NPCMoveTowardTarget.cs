using UnityEngine;
using UnityEngine.AI;
// Makes the NPC move toward a target point using NavMeshAgent

[RequireComponent(typeof(NavMeshAgent))]
public class npcMoveTowardTarget : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform destination;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = destination.position;
    }
}
