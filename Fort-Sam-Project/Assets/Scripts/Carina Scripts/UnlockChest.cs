using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockChest : MonoBehaviour
{
    public GameObject lockPanel;

    private void OnMouseDown()
    {
        CloseLockWindow();
    }
    public void CloseLockWindow()
    {
        if (lockPanel != null)
        {
            bool isActive = lockPanel.activeSelf;
            lockPanel.SetActive(!isActive);
        }
    }
}
