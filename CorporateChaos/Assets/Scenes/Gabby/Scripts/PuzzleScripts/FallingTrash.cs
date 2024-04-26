using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallingTrash : MonoBehaviour
{
    public float range;
    public bool isCaught;
    public List<Sprite> sprites;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(transform.position.y - range, transform.position.y + range), transform.position.y, 0);
        GetComponent<Image>().sprite = sprites[Random.Range(0, sprites.Count - 2)];
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
