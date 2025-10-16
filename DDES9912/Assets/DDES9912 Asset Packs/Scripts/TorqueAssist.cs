using UnityEngine;

public class TorqueAssist : MonoBehaviour
{
    public Rigidbody flywheelRigidbody;
    public float baseTorque = 0.15f;
    public float boostTorque = 10f;
    public float boostRange = 25f;

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
        float angle = flywheelRigidbody.rotation.eulerAngles.z;

        Vector3 torqueDir = Vector3.forward;

        bool nearTopDeadPoint = Mathf.Abs(Mathf.DeltaAngle(angle, 0f)) < boostRange;
        bool nearBottomDeadPoint = Mathf.Abs(Mathf.DeltaAngle(angle, 180f)) < boostRange;

        float appliedTorque = baseTorque;

        if (nearTopDeadPoint || nearBottomDeadPoint)
        {
            appliedTorque += boostTorque;
        }

        flywheelRigidbody.AddTorque(Vector3.forward * baseTorque, ForceMode.Acceleration);
    }
}
