using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomArea : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public string name;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.GetComponent<RoomTracker>().isInRoom = name;
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            enemy.GetComponent<RoomTracker>().isInRoom = name;
        }
    }


}
