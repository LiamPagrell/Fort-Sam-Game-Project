using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCalendar : MonoBehaviour
{
    public GameObject lockPanel;


    private void OnMouseDown()
    {
        if (lockPanel != null)
        {
            bool isActive = lockPanel.activeSelf;
            lockPanel.SetActive(!isActive);
        }
    }
}
