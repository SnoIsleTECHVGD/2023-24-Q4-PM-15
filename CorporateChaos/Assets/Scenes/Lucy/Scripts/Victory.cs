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
    public SortPuzzleControl Winnnn;
    public TrashCanMove Winnnnn;
    public PlungerPuzzleInnerWorkings Winnnnnn;

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

        if (Winnn.fullyTransparent == true)
        {
            VictoryPanelOpened = true;
            SetVictoryPanelVisibility();
        }
        if (Winnnn.taskComplete.activeSelf)
        {
            VictoryPanelOpened = true;
            SetVictoryPanelVisibility();
        }
        if (Winnnnn.caughtCount > 10)
        {
            VictoryPanelOpened = true;
            SetVictoryPanelVisibility();
        }

        if (Winnnnnn.unClogged == true)
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
