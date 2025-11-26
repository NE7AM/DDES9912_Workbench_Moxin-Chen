using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class NPCReturnController : MonoBehaviour
{
    public Transform returnPoint;
    private NavMeshAgent agent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Call this function after the NPC triggers the button
    public void ReturnToStart()
    {
        if (agent != null && returnPoint != null)
        {
            agent.SetDestination(returnPoint.position);
        }
    }

    // Wait for a short delay before returning to the original position
    public IEnumerator DelayedReturn(float delay)
    {
        yield return new WaitForSeconds(delay); 
        ReturnToStart(); 
    }
}
