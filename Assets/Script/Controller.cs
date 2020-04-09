using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    float moveX;
    bool grounded;
    bool jumping;
    
    
    private Model theModel;

    void Start()
    { 
        theModel = GetComponent<GameManager>().theModel;
        theModel.SetCharacterController(GetComponent<CharacterController>());
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        bool jumpPressed = Input.GetButtonDown("Jump");

    }
    private void FixedUpdate()
    {
        if (jumping)
        {
            if (jumpTime > 0.0f)
            {
                rb.velocity = new Vector2(moveX * speed, jumpspeed);
            }
        }
        else if (IsGrounded)
        {
            rb.velocity = new Vector2(moveX * speed, 0.0f);
        }
    }
}
