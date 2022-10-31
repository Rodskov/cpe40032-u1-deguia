using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 10.0f;
    private float rotationSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Player input to move
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Moves player forward or backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Tilts player to right or left direction
        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * horizontalInput);
                
    }
}
