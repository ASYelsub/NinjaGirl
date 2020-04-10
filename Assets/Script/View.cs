using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    Animator animator; 
    Rigidbody2D rb; 
    SpriteRenderer sprite;

    public void SetGrounded(bool isGrounded)
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        animator.SetBool("Grounded", isGrounded);
        // Animator parameters
    }

    public void SmallMove(bool smallMove)
    {
        sprite.flipX = smallMove;
    }
    public void Move(float moveX)
    {
        animator.SetFloat("speed", Mathf.Abs(moveX));  
        // Reverse horizontal 
    }

    public void IsGrounded(float moveX, float speed)
    {
        rb.velocity = new Vector2(moveX * speed, 0.0f);
    }

    public void Jumping(float moveX, float speed, float jumpSpeed)
    {
        rb.velocity = new Vector2(moveX * speed, jumpSpeed);
    }
    
}
