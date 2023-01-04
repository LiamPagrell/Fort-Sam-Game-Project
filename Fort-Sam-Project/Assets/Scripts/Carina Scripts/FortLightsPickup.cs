using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortLightsPickup : MonoBehaviour
{
    float checkDistance;
    float pickUpDistance = 10f;

    [SerializeField] GameObject buildFortIconActivate;

    Movement player;

    private void Start()
    {
        player = FindObjectOfType<Movement>();
    }

    public void OnMouseDown()
    {
        checkDistance = Vector2.Distance(this.transform.position, player.transform.position);

        //if (checkDistance < pickUpDistance)
        if (Input.GetMouseButtonDown(0) && checkDistance < pickUpDistance && CompareTag("Interactable"))
        {
            BookBuildFort.FindObjectOfType<BookBuildFort>().BuildFort(true);
            buildFortIconActivate.SetActive(true);
            Destroy(gameObject);
        }
    }
}
