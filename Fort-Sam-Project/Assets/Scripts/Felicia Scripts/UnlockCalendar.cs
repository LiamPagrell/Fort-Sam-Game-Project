using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCalendar : MonoBehaviour
{
    public GameObject lockPanel;
    public GameObject zoomObject;
    public SoundManager soundManager;

    //Movement player;

    //float checkDistance;
    //float pickUpDistance = 3.6f;


    private void Start()
    {
        //player = FindObjectOfType<Movement>();
    }

    private void OnMouseDown()
    {
        //checkDistance = Vector2.Distance(this.transform.position, player.transform.position);

        if (lockPanel != null)
        {
            //if (!calender.activeSelf && !photo.activeSelf && !drawing.activeSelf)
            if (!zoomObject.activeSelf)
            {
                bool isActive = lockPanel.activeSelf;
                lockPanel.SetActive(!isActive);
                soundManager.TurningPages();
            }

        }
        /*if (checkDistance < pickUpDistance)
        {

        }*/

    }
}
