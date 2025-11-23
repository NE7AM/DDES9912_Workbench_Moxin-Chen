using UnityEngine;


public class PackageMove : MonoBehaviour
{
    public Transform piston;
    public Vector3 moveDirection = Vector3.right;
    public float multiplier = 0.1f; // Movement strength

    private float lastPistonX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (piston != null)
            lastPistonX = piston.localPosition.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (piston == null) return;

        float delta = piston.localPosition.x - lastPistonX;

        // Mathf.Abs(delta) ensures the package always moves forward
        transform.Translate(moveDirection * Mathf.Abs(delta) * multiplier, Space.World);

        lastPistonX = piston.localPosition.x;
    }
}
