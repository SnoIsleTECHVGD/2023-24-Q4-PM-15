using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCanMove : MonoBehaviour
{
    public int caughtCount = 0;
    public GameObject trashSpawner;
    public GameObject boundaryRight;
    public GameObject boundaryLeft;

    public bool check = true;
    public Victory Congrats;
    public CheckOff taskList;

    public List<OverworldTaskVisual> objects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mousePosition.x < boundaryRight.transform.position.x && Input.mousePosition.x > boundaryLeft.transform.position.x)
        {
            transform.position = new Vector3(Input.mousePosition.x, this.transform.position.y, 0);
        }
        if (caughtCount > 10 && check)
        {
            foreach(OverworldTaskVisual item in objects)
            {
                item.changeVisibility();

            }
            trashSpawner.GetComponent<SpawnTrash>().canSpawn = false;
            trashSpawner.GetComponent<SpawnTrash>().enabled = false;
            trashSpawner.SetActive(false);
            taskList.checkTask(1);
            Congrats.Congrats();
            check = false;
            this.transform.parent.gameObject.SetActive(false);

        }
    }
}
