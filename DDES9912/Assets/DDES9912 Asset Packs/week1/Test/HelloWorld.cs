using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int a;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World" + a);

        a = a + 2;
    }
}
