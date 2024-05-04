using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private AudioClip popClean;
    public void MainScene()
    {
        SceneManager.LoadScene("MasterScene");
        SFXmanager.instance.PlaySFX(popClean, transform, 1f);
    }
    public void Quit() 
    { 
        Application.Quit();
        SFXmanager.instance.PlaySFX(popClean, transform, 1f);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
        SFXmanager.instance.PlaySFX(popClean, transform, 1f);
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
        SFXmanager.instance.PlaySFX(popClean, transform, 1f);
    }
}
