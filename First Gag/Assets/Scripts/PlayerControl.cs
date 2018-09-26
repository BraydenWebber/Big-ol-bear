﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    // Player Movement Variables
    public float MoveSpeed;
    public float JumpHeight;
    private bool doubleJump;

    //Player grounded variables
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    // //Non-Stick Player
    private float moveVelocity;


    // Use this for initialization
    void Start()
    {

    }


    private void FixedUpdate()
    {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update()
    {

        //This code makes the charecter jump
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jump();
        }

        // Duoble jump code
        if(grounded)
            doubleJump = false;

        if (Input.GetKeyDown(KeyCode.Space) && !doubleJump && !grounded)
        {
            Jump();
            doubleJump = true;
        }



        //Non-Stick Player
        moveVelocity = 0f;

        // This code maks the character move from side to side using the A&D keys
        if (Input.GetKey(KeyCode.D))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = MoveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = -MoveSpeed;

            GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
        }

        public void Jump()
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
        }




    }

}