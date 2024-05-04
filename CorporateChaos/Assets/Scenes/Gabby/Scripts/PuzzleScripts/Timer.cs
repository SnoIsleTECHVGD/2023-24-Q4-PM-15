using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public int minutes;
    public int seconds;
    public GameObject gameOver;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator timer()
    {
        while (true)
        {
            if (minutes > 0 || seconds > 0)
            {
                
                if (seconds > 0)
                {
                    seconds--;
                }
                else
                {
                    minutes--;
                    seconds = 59;
                }
                decrementDigits();
                yield return new WaitForSeconds(1);
            }
            else
            {
                Debug.Log("Time's up");
                SceneManager.LoadScene("LoseScene");
                break;
            }
        }
    }
    public void decrementDigits()
    {
        if (seconds < 10)
        {
            text.GetComponent<TextMeshProUGUI>().text = minutes.ToString() + ":0" + seconds.ToString();
        }
        else
        {
            text.GetComponent<TextMeshProUGUI>().text = minutes.ToString() + ":" + seconds.ToString();
        }
        
    }
}
