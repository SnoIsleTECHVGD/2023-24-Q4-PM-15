using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskList : MonoBehaviour
{
    public List<bool> checklist;
    public List<GameObject> tasks;
    public List<GameObject> activationCircles;
    public GameObject win;
    public int tasksDone;

    // Update is called once per frame
    void Update()
    {
        tasksDone = 0;
        for(int i = 0; i < checklist.Count; i++)
        {
            if (checklist[i])
            {
                tasksDone++;
                tasks[i].SetActive(true);
            }
        }
        if (tasksDone == checklist.Count)
        {
            Debug.Log("All tasks done!!");
            SceneManager.LoadScene("WinScene");
        }
    }
}
