using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform groundCheck; // Object inside the bottom of the Player
    public LayerMask groundMask; // Actual ground

    public float speed = 12f;
    public float runSpeed = 30f;
    public float gravity = -9.81f;
    public float groundDistance = 0.4f; // Radius of sphere
    public float jumpHeight = 3f;

    //public float torque = 2;
    //public Rigidbody rb;

    Vector3 velocity;
    bool isGrounded;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
       

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //rb.AddRelativeForce(Vector3.forward * torque);

        Vector3 move = transform.right * x + transform.forward * z;

        if (Input.GetButtonDown("Run"))
        {
            controller.Move(move * runSpeed * Time.deltaTime);
            print("running");
        }
        else
        {
            controller.Move(move * speed * Time.deltaTime);
        }
        

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        
    }
}
