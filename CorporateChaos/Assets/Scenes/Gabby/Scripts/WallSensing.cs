using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSensing : MonoBehaviour
{
    public bool isTouchingWall;
    public bool isTouchingRobot;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isTouchingWall = true;
        }
        if (collision.gameObject.tag == "Robot")
        {
            isTouchingRobot = true;
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isTouchingWall = true;
        }
        if (collision.gameObject.tag == "Robot")
        {
            isTouchingRobot = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isTouchingWall = false;
        }
        if (collision.gameObject.tag == "Robot")
        {
            isTouchingRobot = false;
        }
    }
}
