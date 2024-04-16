using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public GameObject VictoryPanel = null;
    public bool VictoryPanelOpened = false;
    public VendingMachine Win;

    public void Congrats()
    {
        if (Win.CurrentKickCount == 20)
        {
            VictoryPanelOpened = true;
            SetVictoryPanelVisibility();
            
        }
    }
    public void SetVictoryPanelVisibility()
    {
       if (VictoryPanel != null)
       {
            VictoryPanel.SetActive(VictoryPanelOpened);
       }
    }
    public void ExitVictoryPanel()
    {
        VictoryPanelOpened = false;
        SetVictoryPanelVisibility();
    }
}
