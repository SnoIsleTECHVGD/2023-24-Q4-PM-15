using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoomArea : MonoBehaviour
{
    public GameObject exitPointIncrease;
    public GameObject exitPointDecrease;
    public GameObject exitPointSpecial1;
    public GameObject exitPointSpecial2;
    public float roomNum;
    public bool veto = false;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Sensor")
        {
            collision.gameObject.GetComponent<RoomTracker>().isInRoom = roomNum;
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Chase>().isInRoom = this.gameObject;
            collision.gameObject.GetComponent<RoomTracker>().isInRoom = roomNum;
            veto = true;
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<RoomTracker>().isInRoom = roomNum;
        }
        else if (collision.gameObject.tag == "Enemy" && !veto)
        {
            collision.gameObject.GetComponent<Chase>().isInRoom = this.gameObject;
            collision.gameObject.GetComponent<RoomTracker>().isInRoom = roomNum;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            veto = false;
        }
    }

}
