using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleActivation : MonoBehaviour
{
    // Start is called before the first frame update
    public bool canOpenPuzzle;
    public GameObject puzzleScreen;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.GetChild(0).gameObject.SetActive(true);
            canOpenPuzzle = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.GetChild(0).gameObject.SetActive(false);
            puzzleScreen.SetActive(false);
            canOpenPuzzle = false;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canOpenPuzzle)
        {
            puzzleScreen.SetActive(true);
        }
    }
}
