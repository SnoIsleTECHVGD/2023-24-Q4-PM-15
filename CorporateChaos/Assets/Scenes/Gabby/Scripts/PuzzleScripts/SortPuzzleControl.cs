using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortPuzzleControl : MonoBehaviour
{
    public List<GameObject> items;
    public GameObject taskComplete;
    public int i;

    public int spotShift1;
    public int spotShift2;
    public int spotShift3;
    public int spotShift4;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;

        spotShift1 = 0;
        spotShift2 = 0;
        spotShift3 = 0;
        spotShift4 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (i < items.Count)
        {
            items[i].SetActive(true);
            if (items[i].GetComponent<Sort>().isSorted)
            {
                i++;
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
                {
                    items[i].GetComponent<Sort>().doSort(1, spotShift1);
                    if (items[i].GetComponent<Sort>().isSorted)
                    {
                        spotShift1 += 5;
                    }
                }
                else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
                {
                    items[i].GetComponent<Sort>().doSort(2, spotShift2);
                    if (items[i].GetComponent<Sort>().isSorted)
                    {
                        spotShift2 += 5;
                    }
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
                {
                    items[i].GetComponent<Sort>().doSort(3, spotShift3);
                    if (items[i].GetComponent<Sort>().isSorted)
                    {
                        spotShift3 += 5;
                    }
                }
                else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
                {
                    items[i].GetComponent<Sort>().doSort(4, spotShift4);
                    if (items[i].GetComponent<Sort>().isSorted)
                    {
                        spotShift4 += 5;
                    }
                }
                else if (Input.anyKeyDown)
                {
                    items[i].GetComponent<Sort>().doSort(5, spotShift4);
                }
            }
        }
        else
        {
            taskComplete.SetActive(true);
        }
        
    }
}
