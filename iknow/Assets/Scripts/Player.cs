using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] CharacterController characterController;
    [SerializeField] float speed = 5.0f;

    //Gravity
    private float gravity = -9.81f;
    Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.1f;
    public LayerMask groundMask;
    bool isGrounded;
     

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Input
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");

        //Gravity
        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2;
        }
        
        //Sprinting
        if (Input.GetKey("left shift"))
        {
            speed = 8.5f;
        }
        else{
            speed = 5f;
        }

        //Move
        Vector3 move = transform.right * xMove + transform.forward * zMove;
        characterController.Move(move * speed * Time.deltaTime);

        
    }
}
