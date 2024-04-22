using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour

{
    public GameObject PausedGame = null;
    public bool PausePanelOpened = false;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PausePanelOpened == false)
            {
                Paused();
            }

            else
            {
                Resume();
            }
        }
    }
    public void Paused()
    {
       PausePanelOpened = true;
        SetPauseVisibility();
        Time.timeScale = 0f;
    }

    public void SetPauseVisibility()
    {
        if (PausedGame != null)
        {
            PausedGame.SetActive(PausePanelOpened);
        }
    }

    public void Resume()
    {
        PausePanelOpened = false;
        Time.timeScale = 1f;
        SetPauseVisibility();
    }
}
