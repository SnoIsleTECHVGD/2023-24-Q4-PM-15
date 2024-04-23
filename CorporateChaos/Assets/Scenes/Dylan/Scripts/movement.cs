using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    public KeyCode left, right, up, down;
    public float moveSpeed;
    float horizontalInput;
    float verticalInput;
    bool isFacingRight = false;

    Vector2 moveing;

    Animator playerAnimator;
    public Rigidbody2D rb2D;


    // Update is called once per frame
    private void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        moveing.x = Input.GetAxisRaw("Horizontal");
        moveing.y = Input.GetAxisRaw("Vertical");

        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        FlipSprite();

        GetComponent<Animator>().SetInteger("WalkDirection", 0);

        //hook up animations later
        if (Input.GetKey(left))
        {
            GetComponent<Animator>().SetInteger("WalkDirection", 1);
        }
        if (Input.GetKey(right)) 
        {
            GetComponent<Animator>().SetInteger("WalkDirection", 1);
        }
        if (Input.GetKey(down))
        {
            GetComponent<Animator>().SetInteger("WalkDirection", 2);
        }
        if (Input.GetKey(up))
        {
            GetComponent<Animator>().SetInteger("WalkDirection", 3);
        }
    }

    void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + moveing * moveSpeed * Time.fixedDeltaTime);
        playerAnimator.SetFloat("xVelocity", Mathf.Abs(rb2D.velocity.x));
        playerAnimator.SetFloat("yVelocity", rb2D.velocity.y);
    }

    void FlipSprite()
    {
        if(isFacingRight && horizontalInput < 0f || !isFacingRight && horizontalInput > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }
}
    
