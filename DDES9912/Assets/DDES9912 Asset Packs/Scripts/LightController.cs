using UnityEngine;

public class LightController : MonoBehaviour
{
    public Renderer lampRenderer;
    public Light pointLight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (lampRenderer == null)
            lampRenderer = GetComponent<Renderer>();

        if (pointLight == null)
            pointLight = GetComponentInChildren<Light>();

        SetStopColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetStopColor()
    {
        SetColor(Color.red);
    }

    public void SetStartColor()
    {
        SetColor(new Color(0.4f, 1f, 0f)); 
    }

    public void SetFastColor()
    {
        SetColor(Color.green);
    }

    public void SetSlowColor()
    {
        SetColor(Color.yellow);
    }


    private void SetColor(Color c)
    {
        if (lampRenderer != null)
        {
            lampRenderer.material.color = c;
            lampRenderer.material.SetColor("_EmissionColor", c);
        }

        if (pointLight != null)
        {
            pointLight.color = c;
            pointLight.intensity = 4f;
        }
    }
}
