using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendingMachine : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            IncreaseKick();
       
        }    
       

    }
    public GameObject Machinekick;
    public double CurrentKickCount { get; set; }
    private GameObject FoodGiver;

public void OnMachinekick()
    {
        IncreaseKick();
        FoodGiver.transform.localScale = new Vector3(1f, 1f, 1f);
    }
    public void IncreaseKick()
    {
        CurrentKickCount += 1;
        print(CurrentKickCount);
    }
}
