using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<Animator>().runtimeAnimatorController)
        {
            this.GetComponent<Image>().sprite = this.GetComponent<SpriteRenderer>().sprite;
        }
    }
}
