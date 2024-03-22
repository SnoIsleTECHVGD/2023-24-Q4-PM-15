using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoomArea : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject exitPointIncrease;
    public GameObject exitPointDecrease;
    public GameObject exitPointSpecial1;
    public GameObject exitPointSpecial2;
    public float roomNum;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.GetComponent<RoomTracker>().isInRoom = roomNum;
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            enemy.GetComponent<Chase>().isInRoom = this.gameObject;
            enemy.GetComponent<RoomTracker>().isInRoom = roomNum;
        }
    }


}
