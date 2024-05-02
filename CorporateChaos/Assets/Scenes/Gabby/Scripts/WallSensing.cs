using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSensing : MonoBehaviour
{
    public bool isTouchingWall;
    public bool isTouchingRobot;

    public float setX;
    public float setY;

    public void Update()
    {
        if (new Vector3(setX, setY, 0) != this.transform.localPosition)
        {
            transform.localPosition = new Vector3(setX, setY, 0);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Obstacle")
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
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Obstacle")
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
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Obstacle")
        {
            isTouchingWall = false;
        }
        if (collision.gameObject.tag == "Robot")
        {
            isTouchingRobot = false;
        }
    }
}
