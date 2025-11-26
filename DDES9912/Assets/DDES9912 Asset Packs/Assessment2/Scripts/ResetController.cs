using UnityEngine;

public class ResetController : MonoBehaviour
{
    public Transform packageOriginalPos;
    public GameObject package;
    public NPCMoveTowardTarget npcMove;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetAll()
    {
        // 1. Reset the package back to its original position
        if (package != null && packageOriginalPos != null)
        {
            package.transform.position = packageOriginalPos.position;
            package.transform.rotation = packageOriginalPos.rotation;
            package.SetActive(true);
        }

        // 2. Allow the NPC to walk again to press the button
        if (npcMove != null)
        {
            npcMove.canMove = true;
        }

        Debug.Log("System RESET!");
    }
}
