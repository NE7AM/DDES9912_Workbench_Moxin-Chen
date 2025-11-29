using UnityEngine;

public class GroundTrigger : MonoBehaviour
{
    public GameObject package;
    public ParticleSystem firework;
    public PistonOscillator piston;
    public LightController[] allLamps;
    public AudioSource fireworkSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Only react when the falling object is the package
        if (!other.CompareTag("Package")) return;

        // 1. Play the firework effect
        if (firework != null)
            firework.Play();

        // 2. Stop the engine system
        if (piston != null)
            piston.Stop();

        // 3. Hide the package once it hits the ground
        if (package != null)
            package.SetActive(false);

        // 4. Reset all lamps to red color
        if (allLamps != null)
        {
            foreach (var lamp in allLamps)
            {
                if (lamp != null)
                    lamp.SetStopColor();
            }
        }

        // 5. Play firework sound
        if (fireworkSound != null)
            fireworkSound.Play();
    }
}
