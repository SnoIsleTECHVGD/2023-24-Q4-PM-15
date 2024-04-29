using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shredder : MonoBehaviour
{
    Vector2 difference = Vector2.zero;
    public GameObject Paper;
   

    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }

    private void OnMouseDrag()
    {
        GetComponent<Rigidbody2D>().position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }

    
}
