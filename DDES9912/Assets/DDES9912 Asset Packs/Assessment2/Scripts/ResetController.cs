using UnityEngine;

public class ResetController : MonoBehaviour
{
    public Transform packageOriginalPos;
    public GameObject package;
    public NPCMoveTowardTarget npcMove;
    public LightController[] allLamps;
    public PistonOscillator piston;
    public ValveController valve;
    public LeverController lever;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Called by the Reset button
    public void ResetAll()
    {
        Debug.Log("System RESET!");

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

        // 3. Reset all lamps to red
        if (allLamps != null)
        {
            foreach (var lamp in allLamps)
            {
                if (lamp != null)
                    lamp.SetStopColor();
            }
        }

        // 4. Stop engine
        if (piston != null)
        {
            piston.SetSpeed(0f);
            piston.SetRange(0f); 
        }

        // 5. Close valve
        if (valve != null)
        {
            valve.CloseValve();
        }

        // 6. Reset lever back to initial up state
        if (lever != null)
        {
            lever.StopLever();
        }

    }
}
