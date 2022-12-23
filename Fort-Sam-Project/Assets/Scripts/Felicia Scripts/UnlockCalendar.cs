using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCalendar : MonoBehaviour
{
    public GameObject lockPanel;
    public GameObject zoomObject;
    public GameObject buttons;
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
                
                StartCoroutine(wait());
                buttons.SetActive(!isActive);
            }

        }
        /*if (checkDistance < pickUpDistance)
        {

        }*/

    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);

    }
}
