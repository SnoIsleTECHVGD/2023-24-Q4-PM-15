using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleActivation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject puzzleScreen;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            puzzleScreen.SetActive(true);
        }
    }
}
