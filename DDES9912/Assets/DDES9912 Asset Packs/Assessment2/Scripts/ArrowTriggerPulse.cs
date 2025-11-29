using UnityEngine;

public class ArrowTriggerPulse : MonoBehaviour
{
    public GameObject arrow;

    public float pulseSpeed = 3f;
    public float pulseStrength = 0.1f;

    private bool isPlayerInside = false;
    private Vector3 originalScale;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Hide the arrow at the start
        if (arrow != null)
        {
            arrow.SetActive(false);
            originalScale = arrow.transform.localScale;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // If player is inside, make the arrow pulse
        if (isPlayerInside && arrow != null)
        {
            float scaleOffset = Mathf.Sin(Time.time * pulseSpeed) * pulseStrength;
            arrow.transform.localScale = originalScale * (1f + scaleOffset);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // When the player enters the trigger zone, show arrow
        if (other.CompareTag("Player"))
        {
            isPlayerInside = true;
            if (arrow != null)
                arrow.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // When the player leaves the trigger zone, hide arrow
        if (other.CompareTag("Player"))
        {
            isPlayerInside = false;
            if (arrow != null)
            {
                arrow.SetActive(false);
                arrow.transform.localScale = originalScale;
            }
        }
    }
}
