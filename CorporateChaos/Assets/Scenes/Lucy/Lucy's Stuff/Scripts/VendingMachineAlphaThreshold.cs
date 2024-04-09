using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VendingMachineAlphaThreshold : MonoBehaviour
{
    private Image vending_machine;

    private void Awake()
    {
        vending_machine = GetComponent<Image>();
        vending_machine.alphaHitTestMinimumThreshold = 0.001f;
    }
}
