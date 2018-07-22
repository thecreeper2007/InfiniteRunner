using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public Rigidbody playerRB;
    public float speed;
    public float jumpForce;
    
    // Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Move();
        Jump();
        //TODO4 add jumping behaviour
	}

    private void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        //TODO1 create variable for moveForward
        float moveForward = 1;
        //TODO2 change x,z to the correct variables 
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveForward); 

        //TODO3 make public variable speed and set it to 5 in the inspector
        playerRB.AddForce(movement * speed);
    }

    private bool CanJump()
    {
        
        if((playerRB.position.y >= -3.5 && playerRB.position.y < -2) || (playerRB.position.y > -2 && playerRB.position.y < -2.00))
        {
            return true;
        }
        return false;
        
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CanJump())
        {
            playerRB.AddForce(0, jumpForce, 0);
        }

        /*
         Hints: 
                Figure out which key you want to use to jump. How does Unity find that key?
                We want to make the player jump by adding a force to it. What direction should the force be?
                Google is your friend, and feel free to ask your intructors questions!
        */

    }
}
