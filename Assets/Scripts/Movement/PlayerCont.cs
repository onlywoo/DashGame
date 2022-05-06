using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCont : MonoBehaviour
{
    public static PlayerCont instance;

    private Rigidbody2D rb;

    public float playerSpeed;
    public float jumpForce = 700;

    private bool isJumping;

    private float horizontalMovement;
    private float verticalMovement;

    public void Start()
    {
        instance = this;
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.gravityScale = 15;
        playerSpeed = 250;
      
        isJumping = false;


    }

    public void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (horizontalMovement > 0.1f || horizontalMovement < -0.1)
        {
            rb.AddForce(new Vector2(horizontalMovement * playerSpeed, 0f), ForceMode2D.Impulse);
        }


        if ( !isJumping &&  verticalMovement > 0.1f )
            {
                rb.AddForce(new Vector2(0f, verticalMovement * jumpForce), ForceMode2D.Impulse);
            }
        

    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isJumping = false;
            
        }
    }

     void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = true;
                
        }
    } 

}


