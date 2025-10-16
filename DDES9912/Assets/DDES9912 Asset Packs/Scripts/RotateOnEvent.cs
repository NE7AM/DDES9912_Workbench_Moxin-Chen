using UnityEngine;

public class RotateOnEvent : MonoBehaviour
{

    public float upAngle = 0f;
    public float downAngle = 80f;
    public float speed = 180f;  

    private bool rotating = false;
    private float targetAngle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotating)
        {
            float current = transform.localEulerAngles.z;
            float newAngle = Mathf.MoveTowardsAngle(current, targetAngle, speed * Time.deltaTime);
            transform.localEulerAngles = new Vector3(0, 0, newAngle);

            if (Mathf.Abs(newAngle - targetAngle) < 0.1f)
                rotating = false;
        }
    }

    public void StartLever()
    {
        targetAngle = downAngle;
        rotating = true;
    }


    public void StopLever()
    {
        targetAngle = upAngle;
        rotating = true;
    }
}
