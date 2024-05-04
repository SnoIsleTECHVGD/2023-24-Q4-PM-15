using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldTaskVisual : MonoBehaviour
{
    public bool showWhenTaskDone;

    public void changeVisibility()
    {
        if (showWhenTaskDone)
        {
            this.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
