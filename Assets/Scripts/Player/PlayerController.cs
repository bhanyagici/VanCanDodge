using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Veriables
    public float speed = 5.0f;
    public float turnSpeed = 25.0f;
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput();
        
        VerticalInput();
    }

    private void VerticalInput()
    {
        // Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // This is ehere we get player input
        forwardInput = Input.GetAxis("Vertical");
    }

    private void HorizontalInput()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        // Rotate the car based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        

    }
}
