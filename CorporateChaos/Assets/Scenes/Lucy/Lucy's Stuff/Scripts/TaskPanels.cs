using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskPanels : MonoBehaviour
{
   public GameObject TaskPanel = null;
    private bool taskPanelOpened = false;
    private bool inRadius;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inRadius = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        inRadius = false;
    }
    private void Update()
    {
        
        if (inRadius == true && Input.GetKeyDown(KeyCode.E)) 

            {
                ToggleTaskPanel();
            }
    }
    
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
