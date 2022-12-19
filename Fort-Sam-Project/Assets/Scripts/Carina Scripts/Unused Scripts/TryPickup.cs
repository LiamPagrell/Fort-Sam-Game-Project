using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryPickup : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Picked up item!");
            }

        }
    }
}
