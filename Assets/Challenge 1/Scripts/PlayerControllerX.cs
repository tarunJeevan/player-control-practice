using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 5f;
    public float tiltSpeed = 100f;
    public float maxTiltAngle = 30f;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // Move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // Calculate up/down tilt amount based on up/down arrow keys
        float tiltAngle = verticalInput * maxTiltAngle;

        // Apply the tilt 
        Quaternion targetRotation = Quaternion.Euler(-tiltAngle, 0f, 0f);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, tiltSpeed + Time.deltaTime);
    }
}
