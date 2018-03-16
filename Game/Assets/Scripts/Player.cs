using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float movementSpeed;

    [SerializeField]
    private float jumpForce;

    private float horizontal;

    private float Jump;

    private Rigidbody2D myRigidbody;

    private bool isRight = true;

    private Vector2 scale;

    public bool isGrounded = true;




    void Start ()
    {

        myRigidbody = GetComponent<Rigidbody2D>();
		
	}
	

	void FixedUpdate()
    { 

        HandleMovement();
		
	}

    void HandleMovement()
    {

        horizontal = Input.GetAxis("Horizontal");

       

        if(horizontal<0 && isRight)
        {

            Flip();

        }
        else if(horizontal>0 && !isRight)
        {

            Flip();

        }

        if(isGrounded && Input.GetButtonDown("Jump"))
        {

            Jumping();

        }

        myRigidbody.velocity = new Vector2(horizontal * movementSpeed, myRigidbody.velocity.y);

    }

    void Flip()
    {

        isRight = !isRight;

        scale = transform.localScale;

        scale.x *= -1;

        transform.localScale = scale;

    }


    void Jumping()
    {

        isGrounded = false;

        myRigidbody.AddForce(Vector2.up * jumpForce);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "Ground")
        {

            isGrounded = true;

        }

    }
}
