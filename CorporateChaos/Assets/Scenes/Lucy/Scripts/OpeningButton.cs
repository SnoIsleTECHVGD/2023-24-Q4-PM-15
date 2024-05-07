using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningButton : MonoBehaviour
{
    public Canvas[] Continue;
    public AudioClip[] VA;
    private int currentcontinue;
    public AudioSource Source;

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Continue[(int)Mathf.Floor(currentcontinue/3.0f  )].gameObject.SetActive(true);
            currentcontinue++;

            Source.Stop();
            Source.PlayOneShot(VA[currentcontinue]);
        }
    
    }
}
