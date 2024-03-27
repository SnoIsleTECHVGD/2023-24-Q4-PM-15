using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UIElements;

public class Sort : MonoBehaviour
{
    public bool isSorted;
    public int type;
    public GameObject spot1;
    public GameObject spot2;
    public GameObject spot3;
    public GameObject spot4;
    // Start is called before the first frame update
    void Start()
    {
        isSorted = false;
        type = Random.Range(1, 4);
        //this.GetComponentInChild<TextMesh>().text = type.ToString();
    }

    // Update is called once per frame
    public void doSort(int i)
    {
            if (i == 1)
            {
                if (type == 1)
                {
                    transform.Translate(findX(spot1), findY(spot1), 0);
                    isSorted = true;
                }
                else
                {
                    shake();
                }
            }
            else if (i == 2)
            {
                if (type == 2)
                {
                    transform.Translate(findX(spot2), findY(spot2), 0);
                    isSorted = true;
                }
                else
                {
                    shake();
                }
            }
            else if (i == 3)
            {
                if (type == 3)
                {
                    transform.Translate(findX(spot3), findY(spot3), 0);
                    isSorted = true;
                }
                else
                {
                    shake();
                }
            }
            else if (i == 4)
            {
                if (type == 4)
                {
                    transform.Translate(findX(spot4), findY(spot4), 0);
                    isSorted = true;
                }
                else
                {
                    shake();
                }
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
        transform.Translate(-1, 0, 0);
        yield return new WaitForSeconds(1);
        transform.Translate(1, 0, 0);
        yield return new WaitForSeconds(1);
        transform.Translate(1, 0, 0);
        yield return new WaitForSeconds(1);
        transform.Translate(-1, 0, 0);
        yield return new WaitForSeconds(1);
        transform.Translate(-1, 0, 0);
        yield return new WaitForSeconds(1);
        transform.Translate(1, 0, 0);
    }
}
