using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecideLayer : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            this.GetComponent<SpriteRenderer>().sortingOrder.ToString("Railing");
        }
    }
}
