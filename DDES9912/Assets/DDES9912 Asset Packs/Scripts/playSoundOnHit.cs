using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (audioSource != null && audioSource.clip !=null)
        {
            audioSource.Play();
        }
        else
        { 
            Debug.LogWarning("YOU FORGOT TO PUT AN AUDIOSOURCE ON AND ASSIGN A CLIP"); 
        }
    }
}
