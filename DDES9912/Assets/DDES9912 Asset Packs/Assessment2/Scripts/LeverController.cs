using UnityEngine;

// Controls the rotation animation of a mechanical lever
public class LeverController : MonoBehaviour
{

    public float upAngle = 0f;
    public float downAngle = 80f;
    public float speed = 180f;  

    private bool rotating = false;  // Whether lever is currently rotating
    private float targetAngle;  // The final angle lever should rotate to

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // Smoothly rotates the lever every frame until it reaches the target angle
        if (rotating)
        {
            float current = transform.localEulerAngles.z;
            float newAngle = Mathf.MoveTowardsAngle(current, targetAngle, speed * Time.deltaTime);
            transform.localEulerAngles = new Vector3(0, 0, newAngle);

            // Stop when close enough
            if (Mathf.Abs(newAngle - targetAngle) < 0.1f)
                rotating = false;
        }
    }

    // Activates the lever by rotating it downward
    public void StartLever()
    {
        targetAngle = downAngle;
        rotating = true;
    }

    // Returns lever to the upright position
    public void StopLever()
    {
        targetAngle = upAngle;
        rotating = true;
    }
}
