using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    Animator animator; 
    Rigidbody2D rb; 
    BoxCollider2D boxCollider;
    SpriteRenderer sprite; 
    
    public void SetGrounded(bool isGrounded)
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();

        animator.SetBool("Grounded", isGrounded);
    }

    public void SetRotate(Quaternion rot)
    {
        transform.rotation = rot;
    }

    public void SetAnimationSpeed(float speed)
    {
        animator.SetFloat("MoveSpeed", speed);
    }
}
