using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BednCover : MonoBehaviour
{
    public BoxCollider2D catCollider;
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
            GameObject.Find("PillowAndBlanket_Placeholder").GetComponent<Animator>().SetTrigger("Sheet");
            GameObject.Find("Cat").GetComponent<Animator>().SetTrigger("CatActive");
            GameObject.Find("BigWhiskers").GetComponent<Animator>().SetTrigger("RatRun");

            catCollider.gameObject.GetComponent<BoxCollider2D>().enabled = true;

            soundManager.Cozies();
            soundManager.Purr();

            checkmark.SetActive(true);
            StartCoroutine(WaitDestroy());
        }



    }

    IEnumerator WaitDestroy()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
}
