using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public Animator anim;
    
    //Player Movement Speed
    public float speed;
    [SerializeField] float ySpeed = 1.5f;
    
    private float playerHeight;


    //Our Rigidbody2D reference
    Rigidbody2D rb2d;
    //Current movement
    Vector2 movement = new Vector2();
    //If we are on the ground
    //bool grounded;
    SpriteRenderer spriteRend;
    // Start is called before the first frame update
    void Start()
    {
        //Find our Rigidbody2D
        rb2d = GetComponent<Rigidbody2D>();
        spriteRend = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        playerHeight = GetComponent<SpriteRenderer>().bounds.size.y / 2;

    }
   


    // Update is called once per frame
    void Update()

    {  //get input from player

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");


        // gå från walking till idle
        if (x == 0)
        {
            anim.SetBool("moving", false);

        }
        else
        {
            anim.SetBool("moving", true);
        }

        if (y > 0 || y < 0) // walking animation when y walking
        {
            anim.SetBool("moving", true);
        }


        if (x < 0)
        {
            spriteRend.flipX = true;

        }
        else if (x > 0)
        {
            spriteRend.flipX = false;
        }

        //Only update x direction
        movement.x = x * speed;
        movement.y = y * ySpeed;


        ////If we press jump while grounded, then Jump
        //if (Input.GetButtonDown("Jump") && grounded)
        //{
        //    //velocity jump
        //    //rb2d.velocity = new Vector2(rb2d.velocity.x, jumpPower);

        //    //impulse jump (same result)
        //    rb2d.velocity = new Vector2(rb2d.velocity.x, 0); //Reset our y speed before the jump
        //    rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        //}

        //Use our old y velocity, if movement.y = 0, then we mess with gravity
        //movement.y = rb2d.velocity.y;

        //Update our movement
        rb2d.velocity = movement;

        ClampPlayerMovement();
    }

    private void ClampPlayerMovement()
    {
        Vector3 position = transform.position;
        float distance = transform.position.z - Camera.main.transform.position.z;

        float leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance)).y + playerHeight;
        float rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, distance)).y - playerHeight;

        position.y = Mathf.Clamp(position.y, leftBorder, rightBorder);
        transform.position = position;
    }

    //This is not the best way of controlling if we are grounded.
    //We will look at better solutions at a later date.
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    grounded = true;
    //}

    //void OnTriggerExit2D(Collider2D other)
    //{
    //    grounded = false;
    //}
}