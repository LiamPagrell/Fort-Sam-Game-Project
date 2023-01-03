using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class UnlockChest : MonoBehaviour
{
    public GameObject lockPanel;
    public GameObject zoomObject;
    public GameObject buttons;
    public GameObject closeZO1, closeZO2, closeZO3;
    Movement playerMovement;
    //public GameObject player;
    public ParticleSystem konfetti;

    float checkDistance;
    float pickUpDistance = 3.4f;

    public bool open = false;

    private void Start()
    {
        playerMovement = FindObjectOfType<Movement>();
    }

    private void OnMouseDown()
    {
        checkDistance = Vector2.Distance(this.transform.position, playerMovement.transform.position);

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
                buttons.SetActive(false);
                closeZO1.SetActive(false);
                closeZO2.SetActive(false);
                closeZO3.SetActive(false);

                playerMovement.StopMovement();
                playerMovement.enabled = false;
                playerMovement.gameObject.GetComponent<Animator>().SetBool("moving", false);

                Invoke(nameof(waiter), 0.1f);

            }



        }
    }

    public void UnlockMovement()
    {
        playerMovement.enabled = true;
        playerMovement.StartMovement();
    }

    public void waiter()
    {
        buttons.SetActive(true);
        

    }


}
