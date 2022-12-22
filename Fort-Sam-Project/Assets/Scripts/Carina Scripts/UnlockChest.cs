using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockChest : MonoBehaviour
{
    public GameObject lockPanel;
    public GameObject zoomObject;
    Movement player;

    float checkDistance;
    float pickUpDistance = 3.4f;

    public bool open = false;

    private void Start()
    {
        player = FindObjectOfType<Movement>();
    }

    private void OnMouseDown()
    {
        checkDistance = Vector2.Distance(this.transform.position, player.transform.position);

        if (checkDistance < pickUpDistance && !open)
        {
            CloseLockWindow();
        }
    }
    public void CloseLockWindow()
    {
        if (lockPanel != null)
        {
            if (!zoomObject.activeSelf)
            {
                bool isActive = lockPanel.activeSelf;
                zoomObject.SetActive(!isActive);           
            }
        }
    }
}
