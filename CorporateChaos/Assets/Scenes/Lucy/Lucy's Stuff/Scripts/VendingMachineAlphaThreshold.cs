using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VendingMachineAlphaThreshold : MonoBehaviour
{
    private Image vendingmachineImage;

    private void Awake()
    {
        vendingmachineImage = GetComponent<Image>();
        vendingmachineImage.alphaHitTestMinimumThreshold = 0.001f;
    }
}
