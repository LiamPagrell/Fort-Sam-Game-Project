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
    public SpriteRenderer shadow;

    float scale = 1;
    Vector3 startScale;
    public float minYpos = -0.1f;
    public float maxYpos = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        shadow = GameObject.Find("DropDownShadowSam").GetComponent<SpriteRenderer>();
        //Find our Rigidbody2D
        rb2d = GetComponent<Rigidbody2D>();
        spriteRend = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        playerHeight = GetComponent<SpriteRenderer>().bounds.size.y / 2;

        startScale = transform.localScale;
    }



    // Update is called once per frame
    void Update()

    {  //get input from player

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");


        // gå från walking till idle
        if ((x != 0 || y != 0))
        {
            anim.SetBool("moving", true);
        }
        else
        {
            anim.SetBool("moving", false);
        }

        //if (y > 0 || y < 0) // walking animation when y walking
        //{
        //    anim.SetBool("moving", true);
        //}


        if (x < 0)
        {
            spriteRend.flipX = true;
            shadow.flipX = true;
        }
        else if (x > 0)
        {
            spriteRend.flipX = false;
            shadow.flipX = false;
        }

        //Only update x direction
        movement.x = x * speed;
        movement.y = y * ySpeed;


       
        float testposition = Camera.main.WorldToViewportPoint(transform.position).y;
        scale = Mathf.Lerp(2.5f, 1.5f, Mathf.InverseLerp(minYpos, maxYpos, testposition)); // floatsen går att justera

        scale -= startScale.x; // denna går att justera 

        scale = Mathf.Clamp(scale, 0.5f, 1.5f); // floatsen går att justera

        transform.localScale = startScale * scale;


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

       // ClampPlayerMovement(); ///Ignore because it make the camera a literal cage for the player character

    }
    //private void OnCollisionEnter2D(Collision2D collision) ///Startkod för att fixa Walk anim stop när sam går in i objekt
    //{
    //    anim.SetBool("moving", false);
    //    speed = 0.3f;
    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    speed = 3.5f;
    //}

    private void ClampPlayerMovement()
    {
        Vector3 position = transform.position;
        float distance = transform.position.z - Camera.main.transform.position.z;

        float leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance)).y + playerHeight; // bottom
        float rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, distance)).y - playerHeight/2; // up
        float lBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance)).x + playerHeight/2;
        float rBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance)).x - playerHeight/2;

        position.y = Mathf.Clamp(position.y, leftBorder, rightBorder);
        position.x = Mathf.Clamp(position.x, lBorder, rBorder);
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


    //old scale test code:
    //(x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
    //testposition = Mathf.Clamp(testposition, minYpos, maxYpos);
    //scale = (testposition - minYpos) * (1.1f - 0.85f) / (maxYpos - minYpos) + 0.85f;

    //if (Input.GetMouseButtonDown(0))
    //{
    //    //Debug.Log(Camera.main.ScreenToViewportPoint(Input.mousePosition).y);
    //    //Debug.Log(Camera.main.WorldToViewportPoint(transform.position).y);

    //    Debug.Log(testposition);
    //    testposition = Mathf.Lerp(2.5f, 1.5f, Mathf.InverseLerp(minYpos, maxYpos, testposition));
    //    Debug.Log(testposition);
    //}
}