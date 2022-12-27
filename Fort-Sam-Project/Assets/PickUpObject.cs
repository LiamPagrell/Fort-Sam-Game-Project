using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public GameObject itemAnimator;
    public GameObject item;
    public GameObject itemDisappear;
    public GameObject player;
    public string animText;

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
            item.SetActive(true);
            itemDisappear.SetActive(false);
            itemAnimator.gameObject.GetComponent<Animator>().Play(animText);           
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
