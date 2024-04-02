using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerX : MonoBehaviour
{
    public float rotationSpeed = 5000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate propeller using its transform component
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
