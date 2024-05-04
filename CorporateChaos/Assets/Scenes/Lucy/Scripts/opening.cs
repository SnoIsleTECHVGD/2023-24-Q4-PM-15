using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opening : MonoBehaviour
{
    public GameObject OpeningPanel = null;
    public bool OpeningPanelOpened = false;

    public void ToggleTaskPanel()
    {
        OpeningPanelOpened = !OpeningPanelOpened;
        SetTaskPanelVisibility();
    }
    public void SetTaskPanelVisibility()
    {
        if (OpeningPanel != null)
        {
            OpeningPanel.SetActive(OpeningPanelOpened);
        }
    }
    public void ExitTaskPanel()
    {
        OpeningPanelOpened = false;
        SetTaskPanelVisibility();
    }
}
