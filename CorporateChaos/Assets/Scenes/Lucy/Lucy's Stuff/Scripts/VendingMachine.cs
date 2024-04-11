using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VendingMachine : MonoBehaviour
{
    [SerializeField] public Animator animator;
    public void kicking()
    {
   
        
            StartCoroutine(Size());

            IncreaseKick();

            Animations();
        


    }

    public GameObject Machinekick;
    public double CurrentKickCount { get; set; }
    public GameObject FoodGiver;
  

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
    public void Endtask()
    {
        if (CurrentKickCount == 20)
        {
            print("Congrats!");
        }
    }

    public IEnumerator Size()
    {
        FoodGiver.transform.localScale = new Vector3(.67f, .67f, .67f);
        yield return new WaitForSeconds(.3f);
        FoodGiver.transform.localScale = new Vector3(.5f, .5f, .5f);
    }

        public void Animations()
    {

        animator.SetTrigger("Play");

    }
   

}
