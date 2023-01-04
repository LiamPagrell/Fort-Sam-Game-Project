using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public GameObject CharAnimator;
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
        checkDistance = Vector2.Distance(this.transform.position, playerMovementScript.transform.position);

        if (Input.GetMouseButtonDown(0) && checkDistance < pickUpDistance && CompareTag("Interactable"))
        {
            playerMovementScript.enabled = false;
            CharAnimator.gameObject.GetComponent<Animator>().Play(charAnimText);
            Invoke(nameof(Items), enumTime);
            //StartCoroutine(Items());
            StartCoroutine(AnimTime());

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Items()
    {
        Debug.Log("move on");
        playerMovementScript.enabled = true;
        itemAppear.SetActive(true);
        itemDisappear.SetActive(false);
    }

    IEnumerator AnimTime()
    {
        yield return new WaitForSeconds(enumTime2);
        itemAnim.gameObject.GetComponent<Animator>().SetTrigger(itemTriggerText);

    }
}
