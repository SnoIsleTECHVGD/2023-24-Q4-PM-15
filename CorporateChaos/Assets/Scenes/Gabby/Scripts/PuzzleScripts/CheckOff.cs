using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOff : MonoBehaviour
{
    public GameObject taskList;
    public int taskNum;
    void Start()
    {
        taskList.GetComponent<TaskList>().checklist[taskNum] = true;
        taskList.GetComponent<TaskList>().tasks[taskNum].SetActive(true);
    }

}
