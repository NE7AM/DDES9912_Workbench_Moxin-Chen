using UnityEngine;

public class ParallelMove : MonoBehaviour
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

    public void OpenValve()
    {
        targetPos = startPos + new Vector3(moveDistance, 0, 0);
        moving = true;
    }

    
    public void CloseValve()
    {
        targetPos = startPos;
        moving = true;
    }
}
