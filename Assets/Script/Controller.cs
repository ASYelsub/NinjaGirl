using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    float moveX;
    bool grounded;
    bool jumping;
    private bool jumpPressed;
    private BoxCollider2D boxCollider;

    private Model theModel;

    void Start()
    { 
        boxCollider = GetComponent<BoxCollider2D>();
        theModel = GetComponent<GameManager>().aModel;
        theModel.SetCharacterController(GetComponent<CharacterController>());
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        jumpPressed = Input.GetButtonDown("Jump");
        // Is platform below us?
    }

    private void FixedUpdate()
    {
        float selfHeightOffset = (boxCollider.size.y / 2.0f) + 0.1f;
        float rayLen =  0.05f;
        Vector2 pos2D = (Vector2)transform.position;
        // Debug.DrawRay(pos2D - (Vector2.up * selfHeightOffset), -Vector2.up * rayLen, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(pos2D - (Vector2.up * selfHeightOffset), -Vector2.up, rayLen);

        theModel.Move(moveX, jumpPressed, hit);
    }
}
