using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using static UnityEditor.Progress;

public class UnlockCalendar : MonoBehaviour
{
    public GameObject lockPanel;
    public GameObject zoomObject;
    public GameObject buttons;
    public GameObject closeZO1, closeZO2, closeZO3, closeZO4, closeZO5, closeZO6;
    TurnOffCollidersScript IntractablesCollScript;
    Movement player;
    public SoundManager soundManager;

    //Movement player;

    //float checkDistance;
    //float pickUpDistance = 3.6f;


    private void Start()
    {
        //player = FindObjectOfType<Movement>();
        player = FindObjectOfType<Movement>();
        IntractablesCollScript = FindObjectOfType<TurnOffCollidersScript>();
    }

    private void OnMouseDown()
    {
        //checkDistance = Vector2.Distance(this.transform.position, player.transform.position);

        if (lockPanel != null)
        {
            //if (!calender.activeSelf && !photo.activeSelf && !drawing.activeSelf)
            //if (!zoomObject.activeSelf)
            //{
            //    bool isActive = lockPanel.activeSelf;
            //    lockPanel.SetActive(!isActive);
            //    buttons.SetActive(false);
            //    closeZO1.SetActive(false);
            //    closeZO2.SetActive(false);
            //    closeZO3.SetActive(false);
            //    closeZO4.SetActive(false);
            //    closeZO5.SetActive(false);
            //    closeZO6.SetActive(false);
            //    soundManager.TurningPages();

            Invoke(nameof(wait), 0.1f);

            //}

        }
        /*if (checkDistance < pickUpDistance)
        {

        }*/

    }

    public void wait()
    {
        //if (!calender.activeSelf && !photo.activeSelf && !drawing.activeSelf)
        if (!zoomObject.activeSelf)
        {
            bool isActive = lockPanel.activeSelf;
            lockPanel.SetActive(!isActive);
            buttons.SetActive(false);
            closeZO1.SetActive(false);
            closeZO2.SetActive(false);
            closeZO3.SetActive(false);
            closeZO4.SetActive(false);
            closeZO5.SetActive(false);
            closeZO6.SetActive(false);
            soundManager.TurningPages();
            buttons.SetActive(true);
            player.gameObject.GetComponent<Movement>().StopMovement();
            player.gameObject.GetComponent<Movement>().enabled = false;
            IntractablesCollScript.gameObject.GetComponent<TurnOffCollidersScript>().TurnOffColls();



        }

    }
}
