using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public GameObject CharAnimator;
    public GameObject player;
    public Movement playerMovementScript;
    public string charAnimText;
   
    public GameObject itemAppear;
    public GameObject itemDisappear;
    public GameObject itemAnim;
    public string itemTriggerText;

    public float enumTime;
    public float enumTime2;

    float checkDistance;
    public float pickUpDistance = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnMouseDown()
    {
        checkDistance = Vector2.Distance(this.transform.position, player.transform.position);

        if (Input.GetMouseButtonDown(0) && checkDistance < pickUpDistance && CompareTag("Interactable"))
        {
            player.gameObject.GetComponent<Movement>().enabled = false;
            playerMovementScript.StopMovement();           
            CharAnimator.gameObject.GetComponent<Animator>().Play(charAnimText);
            StartCoroutine(Items());
            StartCoroutine(AnimTime());

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Items()
    {
        yield return new WaitForSeconds(enumTime);
        player.gameObject.GetComponent<Movement>().enabled = true;
        playerMovementScript.StartMovement();
        itemAppear.SetActive(true);
        itemDisappear.SetActive(false);
    }

    IEnumerator AnimTime()
    {
        yield return new WaitForSeconds(enumTime2);
        itemAnim.gameObject.GetComponent<Animator>().SetTrigger(itemTriggerText);

    }
}
