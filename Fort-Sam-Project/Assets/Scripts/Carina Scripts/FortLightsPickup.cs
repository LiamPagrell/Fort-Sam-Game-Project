using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortLightsPickup : MonoBehaviour
{
    float checkDistance;
    float pickUpDistance = 2f;

    Movement player;

    private void Start()
    {
        player = FindObjectOfType<Movement>();
    }

    public void OnMouseDown()
    {
        checkDistance = Vector2.Distance(this.transform.position, player.transform.position);
        
        if (checkDistance < pickUpDistance)
        {
            BookBuildFort.FindObjectOfType<BookBuildFort>().BuildFort(true);
            Destroy(gameObject);
        }
    }
}
