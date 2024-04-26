using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlungerPuzzleInnerWorkings : MonoBehaviour
{
    Vector2 difference = Vector2.zero;
    public GameObject Toilet;
    public bool unClogged = false;
    public int Counter = 0;

    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }

    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Water.GetComponent<Renderer>().enabled = false;
        Counter = Counter + 1;

        if (Counter == 10)
        {
            unClogged = true;
        }

        if (unClogged == true)
        {
            Debug.Log("toilet is unclogged ");
            Destroy(collision.gameObject);
        }
    }
}
