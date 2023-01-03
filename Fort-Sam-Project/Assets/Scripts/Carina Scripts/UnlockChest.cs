using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class UnlockChest : MonoBehaviour
{
    [SerializeField] TMP_InputField Input;
    public GameObject lockPanel;
    public GameObject zoomObject;
    public GameObject buttons;
    public GameObject closeZO1, closeZO2, closeZO3;
    //public Movement playerMovementScript;
    Movement player;
    //public GameObject player;
    public ParticleSystem konfetti;

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
                buttons.SetActive(false);
                closeZO1.SetActive(false);
                closeZO2.SetActive(false);
                closeZO3.SetActive(false);
                
                //player.gameObject.GetComponent<Movement>().enabled = false;
                //playerMovementScript.StopMovement();
                //player.gameObject.GetComponent<Animator>().SetBool("moving", false);

                StartCoroutine(wait());

            }
            //else
            //{
            //    Debug.Log("movetest1");
            //    player.gameObject.GetComponent<Movement>().enabled = true;
            //    Debug.Log("movetest2");
            //    playerMovementScript.StartMovement();
            //    Debug.Log("movetest3");
            //    player.gameObject.GetComponent<Animator>().SetBool("moving", true);
            //    Input.gameObject.SetActive(false);
            //}
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.1f);
        buttons.SetActive(true);
        

    }


}
