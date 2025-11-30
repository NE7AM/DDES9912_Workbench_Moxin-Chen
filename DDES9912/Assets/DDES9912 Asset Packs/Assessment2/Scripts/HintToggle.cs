using UnityEngine;

// Controls showing and hiding hint text.
public class HintToggle : MonoBehaviour
{
    public GameObject hintText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Hide the hint text
    public void HideHint()
    {
        if (hintText != null)
            hintText.SetActive(false);
    }

    // Show the hint text
    public void ShowHint()
    {
        if (hintText != null)
            hintText.SetActive(true);
    }
}
