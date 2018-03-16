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

    private bool isRight;

    private Vector2 scale;

    private bool isGrounded;


    // Use this for initialization
    void Start ()
    {

        isGrounded = true;

        isRight = true;

        myRigidbody = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update()
    { 

        HandleMovement();
		
	}

    void HandleMovement()
    {

        Jump = Input.GetAxis("Jump");

        horizontal = Input.GetAxis("Horizontal");

        myRigidbody.velocity = new Vector2(transform.position.x, Jump * jumpForce);

        myRigidbody.velocity = new Vector2(horizontal * movementSpeed, transform.position.y);

        if(horizontal<0 && isRight)
        {

            Flip();

        }
        else if(horizontal>0 && !isRight)
        {

            Flip();

        }

    }

    void Flip()
    {

        isRight = !isRight;

        scale = transform.localScale;

        scale.x *= -1;

        transform.localScale = scale;

    }

  
}
