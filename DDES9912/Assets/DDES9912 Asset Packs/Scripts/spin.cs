using UnityEngine;

public class spin : MonoBehaviour
{
    public float yspeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, yspeed, 0);
    }
}
