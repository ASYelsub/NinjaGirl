using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    float moveX;
    bool grounded;
    bool jumping;
    private bool jumpPressed;
    public BoxCollider2D boxCollider;


    private Model theModel;

    void Start()
    { 
        boxCollider = GetComponent<BoxCollider2D>();
        theModel = GetComponent<GameManager>().theModel;
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
        theModel.Move(moveX,jumping, jumpPressed);
    }
}
