using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    
        public float moveSpeed = 5f;

        public Rigidbody2D rb;

        Vector2 movement;
    void Update()
    {   //input
        
        Input.GetAxisRaw("Horizontal");
        
        void FixedUpdate()
    }
}     //movement


