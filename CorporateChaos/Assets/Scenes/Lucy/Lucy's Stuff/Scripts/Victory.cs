using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public GameObject VictoryPanel = null;
    public bool VictoryPanelOpened = false;
    public double CurrentKickCount { get; set; }

    public void Congrats()
    {
        if (CurrentKickCount == 20)
        {
            VictoryPanelOpened=true;
        }
    }
}
