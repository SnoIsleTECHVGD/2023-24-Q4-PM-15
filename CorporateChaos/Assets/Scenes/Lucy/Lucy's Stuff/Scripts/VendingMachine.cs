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
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Size());

            IncreaseKick();

            animator.SetBool("isplayimg", true);
            //ImageChange();
        }


    }

    public GameObject Machinekick;
    public double CurrentKickCount { get; set; }
    public GameObject FoodGiver;
    public Image NormalImage;
    public Sprite HurtImage;

    public void OnMachinekick()
    {
        IncreaseKick();
        FoodGiver.transform.localScale = new Vector3(1f, 1f, 1f);
    }
    public void IncreaseKick()
    {
        CurrentKickCount += .5f;
        print(CurrentKickCount);
    }

    public IEnumerator Size()
    {
        // RectTransform rectTransform = GetComponent<RectTransform>();
        // rectTransform.Rotate(new Vector3(0, 0, 3));
        FoodGiver.transform.localScale = new Vector3(1f, 1f, 1f);
        yield return new WaitForSeconds(.3f);
        FoodGiver.transform.localScale = new Vector3(.5f, .5f, .5f);
    }

        public void Animations()
    {
        animator.SetBool("isplaying", true);
    }
  //  public void ImageChange()
   // {
   //     NormalImage.sprite = HurtImage;
       // yield return new WaitForSeconds(.3f);
      //  HurtImage = NormalImage.sprite;
   // }
}
