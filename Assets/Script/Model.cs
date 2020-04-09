using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    [SerializeField]
    private Controller characterController;
 
    float moveX;
    bool grounded;
    bool jumping;

    float jumpTime;


    public float speed = 1.0f;
    public float jumpspeed = 1.0f;
    public float maxJumpTime = 1.0f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(pos2D - (Vector2.up * selfHeightOffset), -Vector2.up, rayLen);

        grounded = false; //model
        if (hit.collider != null)// model
        {
            if (hit.collider.CompareTag("Platform"))
            {
                grounded = true;
            }
        }
        
        if (grounded)
        {
            moveX = Input.GetAxis("Horizontal");


            if (jumpTime < 0.0f)
            {
                jumping = false;
            }
        }
    }
}
