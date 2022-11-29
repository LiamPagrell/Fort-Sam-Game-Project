using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehaviour : MonoBehaviour
{

    Movement player;

    float checkDistance;
    float pickUpDistance = 3.4f;

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
        if (Input.GetMouseButtonDown(0) && checkDistance < pickUpDistance)
        {
            Debug.Log("Mouse click!");
            Destroy(gameObject);
        }
    }
}
