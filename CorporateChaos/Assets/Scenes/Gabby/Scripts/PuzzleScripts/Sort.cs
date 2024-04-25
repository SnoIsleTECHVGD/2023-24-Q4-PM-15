using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Sort : MonoBehaviour
{
    public bool isSorted;
    public int type;
    public Sprite poster1;
    public Sprite poster2;
    public Sprite poster3;
    public Sprite poster4;
    public GameObject spot1;
    public GameObject spot2;
    public GameObject spot3;
    public GameObject spot4;
    // Start is called before the first frame update
    void Start()
    {
        isSorted = false;
        type = Random.Range(1, 5);
        if (type == 1)
        {
            this.GetComponent<Image>().sprite = poster1;
        }
        else if (type == 2)
        {
            this.GetComponent<Image>().sprite = poster2;
        }
        else if (type == 3)
        {
            this.GetComponent<Image>().sprite = poster3;
        }
        else
        {
            this.GetComponent<Image>().sprite = poster4;
        }

    }

    // Update is called once per frame
    public void doSort(int i, int shift)
    {
            if (i == 1)
            {
                if (type == 1)
                {
                    transform.Translate(findX(spot1), findY(spot1) + shift, 0);
                    isSorted = true;
                }
                else
                {
                StartCoroutine(shake());
                }
            }
            else if (i == 2)
            {
                if (type == 2)
                {
                    transform.Translate(findX(spot2), findY(spot2) + shift, 0);
                    isSorted = true;
                }
                else
                {
                StartCoroutine(shake());
            }
            }
            else if (i == 3)
            {
                if (type == 3)
                {
                    transform.Translate(findX(spot3), findY(spot3) + shift, 0);
                    isSorted = true;
                }
                else
                {
                StartCoroutine(shake());
            }
            }
            else if (i == 4)
            {
                if (type == 4)
                {
                    transform.Translate(findX(spot4), findY(spot4) + shift, 0);
                    isSorted = true;
                }
                else
                {
                StartCoroutine(shake());
            }
            }
            else if (i == 5)
        {
            StartCoroutine(shake());
        }
    }

    public float findX(GameObject spot)
    {
        return spot.GetComponent<RectTransform>().position.x - this.GetComponent<RectTransform>().position.x;
    }

    public float findY(GameObject spot)
    {
        return spot.GetComponent<RectTransform>().position.y - this.GetComponent<RectTransform>().position.y;
    }

    public IEnumerator shake()
    {
        transform.Translate(-5, 0, 0);
        yield return new WaitForSeconds(0.1f);
        transform.Translate(5, 0, 0);
        yield return new WaitForSeconds(0.1f);
        transform.Translate(5, 0, 0);
        yield return new WaitForSeconds(0.1f);
        transform.Translate(-5, 0, 0);
        yield return new WaitForSeconds(0.1f);
        transform.Translate(-5, 0, 0);
        yield return new WaitForSeconds(0.1f);
        transform.Translate(5, 0, 0);
    }
}
