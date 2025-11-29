using UnityEngine;
using UnityEngine.AI;

public class NPCWalkSound : MonoBehaviour
{
    private NavMeshAgent agent;
    private AudioSource audioSrc;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // When NPC is moving AND not already playing sound, play sound
        if (agent.velocity.magnitude > 0.1f)
        {
            if (!audioSrc.isPlaying)
                audioSrc.Play();
        }
        else
        {
            // When NPC stop, stop sound
            if (audioSrc.isPlaying)
                audioSrc.Stop();
        }
    }
}
