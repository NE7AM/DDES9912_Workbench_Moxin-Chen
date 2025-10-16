using UnityEngine;

public class TorqueAssist : MonoBehaviour
{
    public Rigidbody flywheelRigidbody;
    public float assistTorque = 0.05f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        flywheelRigidbody.AddTorque(Vector3.forward * assistTorque, ForceMode.Acceleration);
    }
}
