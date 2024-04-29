using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shredder2 : MonoBehaviour
{
    Vector2 difference = Vector2.zero;
    public GameObject Paper;
    public float transparency = 1f;
    public bool fullyTransparent = false;
    public int transparencyCounter = 1;

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Paper"))
        {
            collision.GetComponent<Image>().color = new Color(1, 1, 1, transparency = transparency - 1f);
            transparencyCounter = transparencyCounter + 1;

            if (transparencyCounter == 1)
            {
                fullyTransparent = true;
            }

            if (fullyTransparent == true)
            {
                Debug.Log("Paper is fully transparent");
                Destroy(collision.gameObject);
            }
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Paper"))
        {
            collision.GetComponent<Image>().color = new Color(1, 1, 1, transparency = transparency - 1f);
            transparencyCounter = transparencyCounter + 1;

            if (transparencyCounter == 1)
            {
                fullyTransparent = true;
            }

            if (fullyTransparent == true)
            {
                Debug.Log("Paper is fully transparent");
                Destroy(collision.gameObject);
            }
        }
    }
}