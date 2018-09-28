using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //Player movement variables
    public float moveSpeed;
    public float jumpHeight;
    private bool doubleJump;

    //Player grounded variables
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatisGround;
    private bool grounded;

    //Non-Slide Player
    private float moveVelocity;

	//Use this for initialization
	private void Start()
	{
		 
	}

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatisGround);
    }

	// Update is called once per frame
	private void Update()
	{
		 //This code makes the charecter jump
        if(Input.GetKeyDown (KeyCode.Space)&& grounded){
            Jump();
        }


        //Double jump code
        if (grounded)
            doubleJump = false;

        if(Input.GetKeyDown (KeyCode.Space)&& !doubleJump && !grounded){
            Jump();
            doubleJump = true;

        }

        //Non-Slide Player
        moveVelocity = 0f;

        //This code makes the character move from side to side using the A&D keys
        if(Input.GetKey (KeyCode.D)){
            //GetComponenet<Rigidbody2D>().velocity = new Vector(moveSpeed, GetComponent<RigidBody2D>().velocity
            moveVelocity = moveSpeed;

        }
        if(Input.GetKey (KeyCode.A)){
            //GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity
            moveVelocity = -moveSpeed;

        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

	}

    public void Jump(){
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }



}