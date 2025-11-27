using UnityEngine;

// Simulates the oscillating motion of a piston using a sine wave function.
public class PistonOscillator : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 sinOffset;
    public float alpha;
    public float sinValue;
    public float rangeFactor;
    public float bobSpeed;

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

    // Adjust oscillation speed dynamically
    public void SetSpeed(float newSpeed)
    {
        bobSpeed = newSpeed;
    }

    public void SetRange(float newRange)
    {
        rangeFactor = newRange;
    }

    // Stop piston movement completely
    public void Stop()
    {
        bobSpeed = 0;
        rangeFactor = 0;
    }
}
