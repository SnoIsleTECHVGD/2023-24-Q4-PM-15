using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public GameObject taskMaster;
    public GameObject enemy;
    public int tasksNeeded;
    public GameObject AIAlert;
    public bool canChangeAI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (taskMaster.GetComponent<TaskList>().tasksDone == tasksNeeded)
        {
            if (canChangeAI)
            {
                List<string> alert = new List<string>();
                alert.Add("!Warning! Unauthorized robot has entered the building");
                alert.Add("It seems to be an angry ex-employee, looking for you.");
                AIAlert.GetComponent<Dialogue>().resetDialogue(alert);
                AIAlert.GetComponent<Dialogue>().activationCircle.SetActive(true);
                AIAlert.GetComponent<Dialogue>().activationCircle.GetComponent<PuzzleActivation>().canOpenPuzzle = true;
                AIAlert.GetComponent<Dialogue>().activationCircle.GetComponent<PuzzleActivation>().puzzleScreen.SetActive(true);
                AIAlert.transform.position = new Vector3(0, 0, 0);
                canChangeAI = false;
            }
            enemy.SetActive(true);
        }
    }
}
