using UnityEngine;

// Controls the opening and closing movement of the valve object.
public class ValveController : MonoBehaviour
{
    public float moveDistance = 0.1f;  
    public float speed = 2f;           

    private Vector3 startPos;
    private Vector3 targetPos;
    private bool moving = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.localPosition;
        targetPos = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            transform.localPosition = Vector3.MoveTowards(
                transform.localPosition, targetPos, speed * Time.deltaTime);
        }
    }

    // Opens the valve by moving it rightwards
    public void OpenValve()
    {
        targetPos = startPos + new Vector3(moveDistance, 0, 0);
        moving = true;
    }

    // Closes the valve by returning to start position
    public void CloseValve()
    {
        targetPos = startPos;
        moving = true;
    }
}
