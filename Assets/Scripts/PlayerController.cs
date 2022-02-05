using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform groundCheck;
    [SerializeField] float groundDistance;
    [SerializeField] float speed;
    [SerializeField] float jumpHeight;
    [SerializeField] float gravity;
    [SerializeField] LayerMask groundMask;
    [SerializeField] CharacterController controller;
    [SerializeField] GameObject door;

    bool isGrounded;
    Vector3 velocity;
    Vector3 move;
    float x;
    float y;
    float z;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Debug.Log("JUMP!");
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 24f;
        }

        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 12f;
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}
