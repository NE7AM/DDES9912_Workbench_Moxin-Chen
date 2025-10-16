using UnityEngine;

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

    public void HideHint()
    {
        if (hintText != null)
            hintText.SetActive(false);
    }

    public void ShowHint()
    {
        if (hintText != null)
            hintText.SetActive(true);
    }
}
