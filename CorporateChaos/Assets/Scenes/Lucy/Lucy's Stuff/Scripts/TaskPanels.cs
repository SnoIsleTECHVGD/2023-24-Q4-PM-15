using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskPanels : MonoBehaviour
{
   public GameObject TaskPanel = null;
    private bool taskPanelOpened = false;
      
    public void ToggleTaskPanel()
    {
        taskPanelOpened = !taskPanelOpened;
        SetTaskPanelVisibility();
    }
    private void SetTaskPanelVisibility()
    {
        if (TaskPanel != null)
        {
            TaskPanel.SetActive(taskPanelOpened);
        }
    }
    private void ExitTaskPanel()
    {
        taskPanelOpened = false;
        TaskPanel.SetActive(taskPanelOpened);
    }
}
