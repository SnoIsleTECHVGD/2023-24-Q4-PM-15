using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortPuzzleControl : MonoBehaviour
{
    public List<GameObject> items;
    public GameObject taskComplete;
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (i < items.Count)
        {
            if (items[i].GetComponent<Sort>().isSorted)
            {
                i++;
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    items[i].GetComponent<Sort>().doSort(1);
                }
                else if (Input.GetKeyDown(KeyCode.Keypad2))
                {
                    items[i].GetComponent<Sort>().doSort(2);
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    items[i].GetComponent<Sort>().doSort(3);
                }
                else if (Input.GetKeyDown(KeyCode.Keypad4))
                {
                    items[i].GetComponent<Sort>().doSort(4);
                }
            }
        }
        else
        {
            taskComplete.SetActive(true);
        }
        
    }
}
