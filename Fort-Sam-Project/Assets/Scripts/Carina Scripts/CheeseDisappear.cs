using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseDisappear : MonoBehaviour
{
    public GameObject cheeseInFridge;
    public GameObject pickupCheese;

    private void OnMouseDown()
    {

        if (cheeseInFridge != null)
        {
            CheesePickup();
        }

    }

    public void CheesePickup()
    {
        pickupCheese.SetActive(true);
        cheeseInFridge.SetActive(false);
    }
}
