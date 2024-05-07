using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MopPuzzleInnerWorkings : MonoBehaviour
{
    [SerializeField] private AudioClip SPLISH;
    Vector2 difference = Vector2.zero;
    public GameObject Water;
    public float transparency = 1f;
    public bool fullyTransparent = false;
    public int transparencyCounter = 0;
    public TaskPanels taskPanels;
    public Victory Congrats;
    public GameObject SpillViz = null;
    public bool SpillVizOpened = true;

    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }

    private void OnMouseDrag()
    {
        GetComponent<Rigidbody2D>().position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SFXmanager.instance.PlaySFX(SPLISH, transform, 1f);
        //Water.GetComponent<Renderer>().enabled = false;
        if (collision.CompareTag("Water"))
        {
            Water.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, transparency = transparency - .1f);
            transparencyCounter = transparencyCounter + 1;

            if (transparencyCounter == 10)
            {
                fullyTransparent = true;
            }

            if (fullyTransparent == true)
            {
                Debug.Log("water is fully transparent");
                Destroy(collision.gameObject);
                EndTask();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Water.GetComponent<Renderer>().enabled = false;
        if (collision.CompareTag("Water"))
        {
            Water.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, transparency = transparency - .1f);
            transparencyCounter = transparencyCounter + 1;

            if (transparencyCounter == 10)
            {
                fullyTransparent = true;
            }

            if (fullyTransparent == true)
            {
                Debug.Log("water is fully transparent");
                Destroy(collision.gameObject);
            }
        }
    }

    public void EndTask()
    {
        if (fullyTransparent == true)
        {
            taskPanels.ExitTaskPanel();
            Congrats.Congrats();
            SpillVizOpened = false;
            SetSpillVizibility();
        }
    }
    public void SetSpillVizibility()
    {
        if (SpillViz != null)
        {
            SpillViz.SetActive(SpillVizOpened);
        }
    }
}
  