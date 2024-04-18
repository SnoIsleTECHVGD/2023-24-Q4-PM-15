using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public GameObject taskMaster;
    public GameObject enemy;
    public int tasksNeeded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (taskMaster.GetComponent<TaskList>().tasksDone == tasksNeeded)
        {
            enemy.SetActive(true);
        }
    }
}
