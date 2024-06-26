using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortPuzzleControl : MonoBehaviour
{
    public List<GameObject> items;
    public GameObject taskComplete;
    public int i;
    public bool check = true;
    public CheckOff taskList;
    public Victory Congrats;

    public int spotShift1;
    public int spotShift2;
    public int spotShift3;
    public int spotShift4;

    public List<OverworldTaskVisual> overworldObjects;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;

        spotShift1 = 4;
        spotShift2 = 4;
        spotShift3 = 4;
        spotShift4 = 4;
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
                    sortOption1();
                }
                else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
                {
                    sortOption2();
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
                {
                    sortOption3();
                }
                else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
                {
                    sortOption4();
                }
                else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Mouse0))
                {
                    items[i].GetComponent<Sort>().doSort(5, spotShift4);
                }
            }
        }
        else
        {
            taskComplete.SetActive(true);
            if (check)
            {
                foreach (OverworldTaskVisual item in overworldObjects)
                {
                    item.changeVisibility();
                }
                taskList.checkTask(0);
                Congrats.Congrats();
                check = false;
                this.gameObject.SetActive(false);
            }
        }
        
    }

    public void sortOption1()
    {
        items[i].GetComponent<Sort>().doSort(1, spotShift1);
        if (items[i].GetComponent<Sort>().isSorted)
        {
            spotShift1 += 5;
        }
    }

    public void sortOption2()
    {
        items[i].GetComponent<Sort>().doSort(2, spotShift2);
        if (items[i].GetComponent<Sort>().isSorted)
        {
            spotShift2 += 5;
        }
    }

    public void sortOption3()
    {
        items[i].GetComponent<Sort>().doSort(3, spotShift3);
        if (items[i].GetComponent<Sort>().isSorted)
        {
            spotShift3 += 5;
        }
    }

    public void sortOption4()
    {
        items[i].GetComponent<Sort>().doSort(4, spotShift4);
        if (items[i].GetComponent<Sort>().isSorted)
        {
            spotShift4 += 5;
        }
    }
}
