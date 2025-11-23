using UnityEngine;
// Makes the assigned InteractableGeneral execute when an NPC enters this trigger

public class TriggerToInteract : MonoBehaviour
{
    // Reference to the InteractableGeneral component
    public InteractableGeneral interactScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Only allow NPC to trigger the button
        if (!other.CompareTag("NPC")) return;

        // Call the original button interaction
        interactScript.onPrimaryInteract.Invoke();

        Debug.Log("NPC triggered button through trigger zone!");
    }
}
