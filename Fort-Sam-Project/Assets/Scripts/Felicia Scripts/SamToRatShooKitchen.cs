using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamToRatShooKitchen : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BigRat"))
        {
            GameObject.Find("BigWhiskers").GetComponent<Animator>().SetTrigger("RatShoo");
        }
    }
}
