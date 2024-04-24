using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject MoveSlide = null;
   // public GameObject MoveSlide2 = null;
    public bool SlideOpened = false;

    public void Update()
    {
        NextSlide();
        LastSlide();
    }
    public void NextSlide()
    {
        SlideOpened = true;
      //  SetSlideVisibility();
       
    }

   // public void SetSlideVisibility()
    //{
     //   if (MoveSlide != null)
     //   {
     //       MoveSlide.SetActive(SlideOpened);
      //  }
      //  if (MoveSlide2 != null)
       // {
      //      MoveSlide2.SetActive(SlideOpened);
      //  }
   // }

    public void LastSlide()
    {
        SlideOpened = false;

       // SetSlideVisibility();
    }
}
