using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallingTrash : MonoBehaviour
{
    public float range;
    public bool isCaught;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(509 - range, 509 + range), transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trash")
        {
            isCaught = true;
            collision.gameObject.GetComponent<TrashCanMove>().caughtCount++;
            Object.Destroy(this.gameObject);
        }
    }
}
