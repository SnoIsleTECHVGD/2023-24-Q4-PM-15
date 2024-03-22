using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSensing : MonoBehaviour
{
    public bool isTouchingWall;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isTouchingWall = true;
            Debug.Log("A sensor is touching a wall");
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isTouchingWall = true;
            Debug.Log("A sensor is touching a wall");
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isTouchingWall = false;
            Debug.Log("A sensor is touching nothing");
        }
    }
}
