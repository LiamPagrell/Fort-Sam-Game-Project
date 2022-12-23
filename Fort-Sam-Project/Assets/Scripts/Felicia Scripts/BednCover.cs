using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BednCover : MonoBehaviour
{
    public GameObject remote;
    public GameObject checkmark;
    public GameObject sam;
    public SoundManager soundManager;

    float checkDistance;
    float pickUpDistance = 4f;

    public void Start()
    {
        
    }
    public void OnMouseDown()
    {
        checkDistance = Vector2.Distance(this.transform.position, sam.transform.position);

        if (Input.GetMouseButtonDown(0) && checkDistance < pickUpDistance && CompareTag("Interactable"))
        {

            sam.gameObject.GetComponent<Animator>().SetTrigger("PickingUpMedium");
            GameObject.Find("PillowAndBlanket_Placeholder").GetComponent<Animator>().SetTrigger("Sheet");
            GameObject.Find("Cat").GetComponent<Animator>().SetTrigger("CatActive");
            GameObject.Find("BigWhiskers").GetComponent<Animator>().SetTrigger("RatRun");



            soundManager.Cozies();
            soundManager.Purr();

            checkmark.SetActive(true);
            Destroy(this.gameObject);
        }



    }
}
