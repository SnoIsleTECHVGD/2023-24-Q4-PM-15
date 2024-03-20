using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public KeyCode left, right, up, down;
    public float moveSpeed;

    public Rigidbody2D rb2D;
    Vector2 moving;

    // Update is called once per frame
    void Update()
    {
        moving.x = Input.GetAxisRaw("Horizontal");
        moving.y = Input.GetAxisRaw("Vertical");

       //hook up animations later
    }

    void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + moving * moveSpeed * Time.fixedDeltaTime);
    }
}
