using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehaviour : MonoBehaviour
{
    //[SerializeField] List<GameObject> pickItems = new List<GameObject>();
    Movement player;

    float checkDistance;
    float pickUpDistance = 3.4f;
    bool isInteractable;

    void Start()
    {
        player = FindObjectOfType<Movement>();
    }


    void Update()
    {
        // check distance between player and interactable object
        checkDistance = Vector2.Distance(this.transform.position, player.transform.position);
    }


    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && checkDistance < pickUpDistance && CompareTag("Interactable"))
        {
            Debug.Log("Mouse click!");
            Destroy(gameObject);
        }

        else if (Input.GetMouseButtonDown(0) && checkDistance < pickUpDistance && CompareTag("Pillow") && !isInteractable)
        {
            isInteractable = true;
            Debug.Log("Mouse click!");
            Destroy(gameObject);
        }
    }
}
