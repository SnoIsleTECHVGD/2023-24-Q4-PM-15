using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisorThat : MonoBehaviour
{
    [SerializeField] private AudioClip popClean;
    public GameObject TaskPanel = null;
    public bool taskPanelOpened = false;

    public void ToggleTaskPanel()
    {
        taskPanelOpened = !taskPanelOpened;
        SetTaskPanelVisibility();
        SFXmanager.instance.PlaySFX(popClean, transform, 1f);
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
