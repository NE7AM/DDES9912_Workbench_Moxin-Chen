using UnityEngine;
using UnityEngine.Android;

// Simulates the oscillating motion of a piston using a sine wave function.
public class PistonOscillator : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 sinOffset;
    public float alpha;
    public float sinValue;
    public float rangeFactor;
    public float bobSpeed;
    
    public AudioSource steamSound;
    public float defaultSpeed = 180f;
    public float basePitch = 0.88f;

    public bool isRunning = false;
    public AudioSource wrongSound;
    public LightController[] allLights;

    public ParticleSystem steam;
    public void StartEngine()
    {
        isRunning = true;

        // Start steam VFX
        if (steam != null)
        {
            steam.gameObject.SetActive(true);
            steam.Play();
        }
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        // Store starting position when script initializes
        startPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // Update piston movement each frame using sine-based motion
        sinValue = Mathf.Sin(alpha * Mathf.Deg2Rad);

        sinOffset.x = sinValue * rangeFactor;

        transform.localPosition = startPosition + sinOffset;

        alpha += bobSpeed * Time.deltaTime;
    }

    
    public void SetSpeed(float newSpeed)
    {
        
        if (!isRunning)
        {
            // Force ALL lights to stay red
            if (allLights != null)
            {
                foreach (var light in allLights)
                {
                    if (light != null)
                        light.SetStopColor();
                }
            }

            // Play error sound
            if (wrongSound != null)
                wrongSound.Play();

            return; // Block everything else
        }

        var emission = steam.emission;
        emission.enabled = true;

        // Adjust oscillation speed dynamically
        bobSpeed = newSpeed;

        // Plays the steam engine sound based on speed changes
        if (steamSound != null)
        {
            if (!steamSound.isPlaying)
                steamSound.Play();

            // Adjust pitch based on speed
            float speedRatio = newSpeed / defaultSpeed;
            steamSound.pitch = basePitch * speedRatio;
        }

        // Adjust lamp color based on speed
        if (allLights != null)
        {
            foreach (var light in allLights)
            {
                if (light == null) continue;

                if (newSpeed >= 200f)
                    light.SetFastColor();
                else if (newSpeed <= 160f)
                    light.SetSlowColor();
                else
                    light.SetStartColor();
            }
        }
    }

    public void SetRange(float newRange)
    {
        rangeFactor = newRange;
    }

    
    public void Stop()
    {
        // Stop piston movement completely
        bobSpeed = 0;
        rangeFactor = 0;

        // Stop the steam sound
        if (steamSound != null)
            steamSound.Stop();

        // Stop steam VFX
        if (steam != null)
        { 
            steam.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            steam.Clear();
        }  
        
        isRunning = false;
    }
}
