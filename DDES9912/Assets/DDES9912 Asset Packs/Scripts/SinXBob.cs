using UnityEngine;

public class SinXBob : MonoBehaviour
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
        startPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        sinValue = Mathf.Sin(alpha * Mathf.Deg2Rad);

        sinOffset.x = sinValue * rangeFactor;

        transform.localPosition = startPosition + sinOffset;

        alpha += bobSpeed * Time.deltaTime;
    }

    public void SetSpeed(float newSpeed)
    {
        bobSpeed = newSpeed;
    }

    public void SetRange(float newRange)
    {
        rangeFactor = newRange;
    }


    public void Stop()
    {
        bobSpeed = 0;
        rangeFactor = 0;
    }
}
