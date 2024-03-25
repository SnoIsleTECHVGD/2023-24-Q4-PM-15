using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VendingMachineAlphaThreshold : MonoBehaviour
{
    private Image FoodGiver;

    private void Awake()
    {
        FoodGiver = GetComponent<Image>();
        FoodGiver.alphaHitTestMinimumThreshold = 0.001f;
    }
}
