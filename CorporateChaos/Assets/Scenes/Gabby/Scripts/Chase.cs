using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class Chase : MonoBehaviour
{
    public GameObject target;

    public GameObject leftSensor;
    public GameObject rightSensor;
    public GameObject upSensor;
    public GameObject downSensor;
    public GameObject isInRoom;
    public GameObject gameOverScreen;
    
    public float targetInRoom;
    public float speed;

    // Update is called once per frame
    void Update()
    {

        if (!(target is null))
        {
            targetInRoom = target.GetComponent<RoomTracker>().isInRoom;
            chase(selectTarget());
            if (transform.rotation.z != 0)
            {
                Quaternion target = Quaternion.Euler(0, 0, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
            }
        }
        
    }

    public void chase(GameObject target)
    {
        float vectorX = target.transform.position.x - transform.position.x;
        float vectorY = target.transform.position.y - transform.position.y;

        if (rightSensor.GetComponent<WallSensing>().isTouchingWall && vectorX > 0)
        {
            vectorX = 0;
        }
        if (rightSensor.GetComponent<WallSensing>().isTouchingRobot && vectorX > 0)
        {
            vectorX = -1;
        }
        if (leftSensor.GetComponent<WallSensing>().isTouchingWall && vectorX < 0)
        {
            vectorX = 0;
        }
        if (leftSensor.GetComponent<WallSensing>().isTouchingRobot && vectorX < 0)
        {
            vectorX = 1;
        }
        if (upSensor.GetComponent<WallSensing>().isTouchingWall && vectorY > 0)
        {
            vectorY = 0;
        }
        if (upSensor.GetComponent<WallSensing>().isTouchingRobot && vectorY > 0)
        {
            vectorY = -1;
        }
        if (downSensor.GetComponent<WallSensing>().isTouchingWall && vectorY < 0)
        {
            vectorY = 0;
        }
        if (downSensor.GetComponent<WallSensing>().isTouchingRobot && vectorY < 0)
        {
            vectorY = 1;
        }
        if ((rightSensor.GetComponent<WallSensing>().isTouchingWall || leftSensor.GetComponent<WallSensing>().isTouchingWall) && upSensor.GetComponent<WallSensing>().isTouchingWall)
        {
            vectorY = -1;
        }
        if ((rightSensor.GetComponent<WallSensing>().isTouchingWall || leftSensor.GetComponent<WallSensing>().isTouchingWall) && downSensor.GetComponent<WallSensing>().isTouchingWall)
        {
            vectorY = 1;
        }
        if ((upSensor.GetComponent<WallSensing>().isTouchingWall && downSensor.GetComponent<WallSensing>().isTouchingWall) && leftSensor.GetComponent<WallSensing>().isTouchingWall)
        {
            vectorX = 1;
        }
        if ((upSensor.GetComponent<WallSensing>().isTouchingWall && downSensor.GetComponent<WallSensing>().isTouchingWall) && rightSensor.GetComponent<WallSensing>().isTouchingWall)
        {
            vectorX = -1;
        }
        if (leftSensor.GetComponent<WallSensing>().isTouchingWall && target.transform.position.x < this.transform.position.x && target.transform.position.y < this.transform.position.y)
        {
            vectorY = 1;
        }

        //get animation direction
        animationDirection(vectorX, vectorY);

        Vector3 toTarget = new Vector3(vectorX, vectorY, 0);
        toTarget = Vector3.Normalize(toTarget);
        if (target.transform.position.x != transform.position.x && target.transform.position.y != transform.position.y)
        {
            transform.Translate(toTarget * Time.deltaTime * speed);
        }
    }

    public GameObject selectTarget()
    {
        if (targetInRoom > this.GetComponent<RoomTracker>().isInRoom)
        {
            return isInRoom.GetComponent<RoomArea>().exitPointIncrease;
        }
        else if (targetInRoom == this.GetComponent<RoomTracker>().isInRoom)
        {
            return target;
        }
        else if (targetInRoom == 3.25f && this.GetComponent<RoomTracker>().isInRoom == 4)
        {
            return isInRoom.GetComponent<RoomArea>().exitPointSpecial1;
        }
        else if (targetInRoom == 3.5f && this.GetComponent<RoomTracker>().isInRoom == 4)
        {
            return isInRoom.GetComponent<RoomArea>().exitPointSpecial2;
        }
        else
        {
            //assume target room number is less than this room number
            return isInRoom.GetComponent<RoomArea>().exitPointDecrease;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameOverScreen.SetActive(true);
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    public void animationDirection(float x, float y)
    {
        float posX = x;
        float posY = y;
        if (x < 0)
        {
            posX *= -1;
        }
        if (y < 0)
        {
            posY *= -1;
        }

        if (y < 0 && posY > posX && GetComponent<Animator>().GetInteger("direction") != 0)
        {
            GetComponent<Animator>().SetInteger("direction", 0);
        }
        else if (posY > posX && GetComponent<Animator>().GetInteger("direction") != 2)
        {
            GetComponent<Animator>().SetInteger("direction", 2);
        }
        else if (GetComponent<Animator>().GetInteger("direction") != 1 && posX > posY)
        {
            GetComponent<Animator>().SetInteger("direction", 1);
        }

        if (x < 0 && posX > posY)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
