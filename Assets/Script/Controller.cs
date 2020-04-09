using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    float moveX;
    bool grounded;
    bool jumping;
    
    float jumpTime;
    
    public float speed = 1.0f;
    public float jumpspeed = 1.0f;
    public float maxJumpTime = 1.0f;
    
    [SerializeField]
    private Model theModel;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
