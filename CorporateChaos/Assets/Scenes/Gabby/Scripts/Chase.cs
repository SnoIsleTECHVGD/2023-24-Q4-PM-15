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
    public GameObject timer;
    public GameObject stuck;
    
    public float targetInRoom;
    public float speed;
    public bool isStuck;

    // Update is called once per frame
    void Update()
    {

        if (!(target is null))
        {
            targetInRoom = target.GetComponent<RoomTracker>().isInRoom;
            chase(selectTarget());
        }
        
    }

    public void chase(GameObject target)
    {
        isStuck = false;
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
        if (Mathf.Abs(vectorX) + Mathf.Abs(vectorY) < 1 && (leftSensor.GetComponent<WallSensing>().isTouchingWall || rightSensor.GetComponent<WallSensing>().isTouchingWall || upSensor.GetComponent<WallSensing>().isTouchingWall || downSensor.GetComponent<WallSensing>().isTouchingWall))
        {
            isStuck = true;
            Vector2 direction = (target.transform.position - this.transform.position).normalized;
            RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, direction);
            Debug.DrawRay(transform.position, direction, Color.red);
            bool hitObstacle = false;

            foreach (RaycastHit2D hit in hits)
            {
                if (hit.collider.tag == "Obstacle")
                {
                    hitObstacle = true;
                    break;
                }
            }

            if (hitObstacle)
            {
                if (leftSensor.GetComponent<WallSensing>().isTouchingWall || rightSensor.GetComponent<WallSensing>().isTouchingWall)
                {
                    vectorY = Mathf.Abs(target.transform.position.x - transform.position.x);
                }
                if (upSensor.GetComponent<WallSensing>().isTouchingWall || downSensor.GetComponent<WallSensing>().isTouchingWall)
                {
                    vectorX = Mathf.Abs(target.transform.position.y - transform.position.y);
                }
            }
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
            if (isInRoom.GetComponent<RoomArea>().hasPlayer == false && isInRoom.GetComponent<RoomArea>().exitPointSpecialCase != null)
            {
                return isInRoom.GetComponent<RoomArea>().exitPointSpecialCase;
            }
            else
            {
                return target;
            }
        }
        else if (targetInRoom == 3.25f && this.GetComponent<RoomTracker>().isInRoom == 4)
        {
            return isInRoom.GetComponent<RoomArea>().exitPointSpecial1;
        }
        else if (targetInRoom == 3.5f && this.GetComponent<RoomTracker>().isInRoom == 4)
        {
            return isInRoom.GetComponent<RoomArea>().exitPointSpecial2;
        }
        else if (targetInRoom == 2.5f && this.GetComponent<RoomTracker>().isInRoom == 3)
        {
            return isInRoom.GetComponent<RoomArea>().exitPointSpecial1;
        }
        else if (isInRoom.GetComponent<RoomArea>().roomNum == 2.5f && isStuck)
        {
            return stuck;
        }
        else if (Mathf.Abs(transform.position.x - stuck.transform.position.x) < 1 && Mathf.Abs(transform.position.y - stuck.transform.position.y) < 1)
        {
            return isInRoom.GetComponent<RoomArea>().exitPointIncrease;
        }
        else
        {
            //assume target room number is less than this room number
            return isInRoom.GetComponent<RoomArea>().exitPointDecrease;
        }
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (timer.GetComponent<Timer>().seconds > 0)
            {
            timer.GetComponent<Timer>().seconds--;
                timer.GetComponent<Timer>().decrementDigits();
            }
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
        else if (y > 0 && posY > posX && GetComponent<Animator>().GetInteger("direction") != 2)
        {
            GetComponent<Animator>().SetInteger("direction", 2);
        }
        else if (GetComponent<Animator>().GetInteger("direction") != 1 && posX > posY)
        {
            GetComponent<Animator>().SetInteger("direction", 1);
        }
        //else if (x + y < 1)
        //{
            //GetComponent<Animator>().SetInteger("direction", 3);
        //}

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
