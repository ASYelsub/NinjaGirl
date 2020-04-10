using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Model
{
    float jumpTime;
    // Game behaviour settings
    public float speed = 1.0f;
    public float jumpspeed = 1.0f;
    public float maxJumpTime = 1.0f;
    float smallMove = 0.0001f;
    private bool jumping;
    
    // Link to view
    public View myView;
    
    //Link to character controller
    private CharacterController myCharacterController;

    // Is the character grounded?
    private bool _isGrounded;

    public bool IsGrounded
    {
        get
        {
            return _isGrounded;
        }
        set
        {
            _isGrounded = value;
            myView.SetGrounded(_isGrounded); //Update the view.
        }
    }

    public void Move(float moveX, bool jumpPressed, RaycastHit2D hit)
    {
        
        IsGrounded = false;
        if (hit.collider != null) 
        {
            if (hit.collider.CompareTag("Platform"))
            {
                IsGrounded = true;
            }
        }
        
        if (IsGrounded)
        {
            if (jumpTime < 0.0f)
            {
                jumping = false;
            }
        }
        if (IsGrounded && jumpPressed && !jumping)
        {
            jumping = true;
            jumpTime = maxJumpTime;
        }
        jumpTime -= Time.deltaTime;
        if (jumping)
        {
            if (jumpTime > 0.0f)
            {
                myView.Jumping(moveX,speed, jumpspeed);
            }
        }
        else if (IsGrounded)
        {
            myView.IsGrounded(moveX,speed);
        }
        if (moveX < -smallMove)
        {
            myView.SmallMove(true);
        }
        else if (moveX > smallMove)
        {
            myView.SmallMove(false);
        }
    }

    public void SetView(View theView)
    {
        myView = theView;
    }

    public void SetCharacterController(CharacterController theCharacterController)
    {
        myCharacterController = theCharacterController;
    }
    
    
}
