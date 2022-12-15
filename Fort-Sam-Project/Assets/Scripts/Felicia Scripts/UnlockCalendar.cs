using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCalendar : MonoBehaviour
{
    public GameObject lockPanel;
    public SoundManager soundManager;


    private void OnMouseDown()
    {
        if (lockPanel != null)
        {
            bool isActive = lockPanel.activeSelf;
            lockPanel.SetActive(!isActive);
            soundManager.TurningPages();
        }
    }
}
