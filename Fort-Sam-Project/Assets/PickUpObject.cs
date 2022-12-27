using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public GameObject CharAnimator;
    public GameObject player;
    public Movement playerMovementScript;
    public string animText;
   
    public GameObject itemAppear;
    public GameObject itemDisappear;


    float checkDistance;
    public float pickUpDistance = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnMouseDown()
    {
        checkDistance = Vector2.Distance(this.transform.position, player.transform.position);

        if (Input.GetMouseButtonDown(0) && checkDistance < pickUpDistance && CompareTag("Interactable"))
        {
            player.gameObject.GetComponent<Movement>().enabled = false;
            playerMovementScript.StopMovement();
            StartCoroutine(Items());

            CharAnimator.gameObject.GetComponent<Animator>().Play(animText);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Items()
    {
        yield return new WaitForSeconds(0.5f);
        player.gameObject.GetComponent<Movement>().enabled = true;
        playerMovementScript.StartMovement();
        itemAppear.SetActive(true);
        itemDisappear.SetActive(false);
    }
}
