using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChestActivate : MonoBehaviour
{
    public GameObject lockPanel;

    public void CloseLockWindow()
    {
        if (lockPanel != null)
        {
            bool isActive = lockPanel.activeSelf;
            lockPanel.SetActive(!isActive);
        }
    }
}
