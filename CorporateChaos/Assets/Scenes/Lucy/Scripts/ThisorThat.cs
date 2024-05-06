using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisorThat : MonoBehaviour
{
    public GameObject TaskPanel = null;
    public bool taskPanelOpened = false;

    public void ToggleTaskPanel()
    {
        taskPanelOpened = !taskPanelOpened;
        SetTaskPanelVisibility();
    }
    public void SetTaskPanelVisibility()
    {
        if (TaskPanel != null)
        {
            TaskPanel.SetActive(taskPanelOpened);
        }
    }
    public void ExitTaskPanel()
    {
        taskPanelOpened = false;
        SetTaskPanelVisibility();
    }
}
