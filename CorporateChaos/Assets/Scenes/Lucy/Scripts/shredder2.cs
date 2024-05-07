using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shredder2 : MonoBehaviour
{
    [SerializeField] private AudioClip SHRED;
    Vector2 difference = Vector2.zero;
    public GameObject Paper;
    public float transparency = 1f;
    public bool fullyTransparent = false;
    public int TransparencyCounter = 1;
    public TaskPanels taskPanels;
    public Victory Congrats;
    public GameObject ShredderViz = null;
    public bool ShredderVizOpened = true;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Paper"))
        {
            SFXmanager.instance.PlaySFX(SHRED, transform, 1f);
            collision.GetComponent<Image>().color = new Color(1, 1, 1, transparency = transparency - 1f);
            TransparencyCounter = TransparencyCounter + 1;

            if (TransparencyCounter >= 1)
            {
                fullyTransparent = true;
            }

            if (fullyTransparent == true)
            {
                Debug.Log("Paper is fully transparent");
                Destroy(collision.gameObject);
            }

            GetComponent<ParticleSystem>().Play();

            Endtask();

        }
        
    }
    public void Endtask()
    {
        if (TransparencyCounter >= 7)
        {
            taskPanels.ExitTaskPanel();
            Congrats.Congrats();
            ShredderVizOpened = false;
            SetShredderVizibility();
        }
    }
    public void SetShredderVizibility()
    {
        if (ShredderViz != null)
        {
            ShredderViz.SetActive(ShredderVizOpened);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Paper"))
        {
            collision.GetComponent<Image>().color = new Color(1, 1, 1, transparency = transparency - 1f);
            TransparencyCounter = TransparencyCounter + 1;

            if (TransparencyCounter >= 1)
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