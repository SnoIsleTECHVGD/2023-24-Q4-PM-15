using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public int minutes;
    public int seconds;
    public GameObject gameOver;
    public GameObject digitOne;
    public GameObject digitTwo;
    public GameObject digitThree;
    public GameObject digitFour;
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
               if (seconds < 10)
                {
                    Debug.Log(minutes + ":0" + seconds);
                }
               else
                {
                    Debug.Log(minutes + ":" + seconds);
                }
                
                if (seconds > 0)
                {
                    seconds--;
                }
                else
                {
                    minutes--;
                    seconds = 59;
                }
                yield return new WaitForSeconds(1);
            }
            else
            {
                Debug.Log("Time's up");
                gameOver.SetActive(true);
                break;
            }
        }
    }
}
