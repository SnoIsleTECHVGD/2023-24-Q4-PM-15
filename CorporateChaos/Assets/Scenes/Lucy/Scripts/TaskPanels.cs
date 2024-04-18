using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TaskPanels : MonoBehaviour
{
   public GameObject TaskPanel = null;
    public bool taskPanelOpened = false;
    public bool inRadius;
    public movement moveing;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        inRadius = true;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        inRadius = false;
    }
    public void Update()
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
    public void BreakLegs()
    {
       GetComponent(moveing).enabled = false;
    }
    
}
