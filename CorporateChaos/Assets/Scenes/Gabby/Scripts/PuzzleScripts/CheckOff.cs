using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOff : MonoBehaviour
{
    public GameObject SortPosters;
    public GameObject ThrowTrash;
    public GameObject FixVending;
    public GameObject MopSpill;
    //public GameObject UnClogToilet;
    public GameObject ShredPapers;

    public GameObject victory;
    void Start()
    {
        //taskList.GetComponent<TaskList>().checklist[taskNum] = true;
        //taskList.GetComponent<TaskList>().tasks[taskNum].SetActive(true);
    }

    public void Update()
    {
        //if (SortPosters.GetComponent<SortPuzzleControl>().taskComplete.active)
        //{
          //  checkTask(0);
            //SortPosters.SetActive(false);
            //victory.SetActive(true);
        //}
        if (ThrowTrash.GetComponent<TrashCanMove>().caughtCount > 10)
        {
            checkTask(1);
            ThrowTrash.GetComponent<TrashCanMove>().trashSpawner.GetComponent<SpawnTrash>().canSpawn = false;
            ThrowTrash.GetComponent<TrashCanMove>().trashSpawner.GetComponent<SpawnTrash>().enabled = false;
            ThrowTrash.SetActive(false);
            victory.SetActive(true);
        }
        if (FixVending.GetComponent<VendingMachine>().CurrentKickCount == 20)
        {
            checkTask(2);
        }
        if (MopSpill.GetComponent<MopPuzzleInnerWorkings>().fullyTransparent)
        {
            checkTask(3);
        }
        //  if (UnClogToilet)
        //  {
        //      checkTask(4);
        //  }
        if (ShredPapers.GetComponent<shredder2>().TransparencyCounter == 7)
        {
            checkTask(5);
        }
    }

    public void checkTask(int taskNum)
    {
        GetComponent<TaskList>().checklist[taskNum] = true;
        GetComponent<TaskList>().tasks[taskNum].SetActive(true);
    }
}
