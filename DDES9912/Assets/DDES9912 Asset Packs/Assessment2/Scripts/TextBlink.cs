using UnityEngine;
using TMPro;

public class TextBlink : MonoBehaviour
{
    public TextMeshPro textObject;
    public float blinkSpeed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (textObject == null) return;

        // Get current color
        Color c = textObject.color;

        // PingPong makes value oscillate between 0 and 1
        c.a = Mathf.PingPong(Time.time * blinkSpeed, 1f);

        // Apply color back to text
        textObject.color = c;
    }
}
