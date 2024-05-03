using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public GameObject VictoryPanel = null;
    public bool VictoryPanelOpened = false;
    public VendingMachine Win;
    public shredder2 Winn;
    public MopPuzzleInnerWorkings Winnn;

    public void Congrats()
    {
        if (Win.CurrentKickCount == 20)
        {
            VictoryPanelOpened = true;
            SetVictoryPanelVisibility();
            
        }
        if (Winn.TransparencyCounter == 7) 
        {
            VictoryPanelOpened = true;
            SetVictoryPanelVisibility();
        }

        if (Winn.fullyTransparent == true)
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
