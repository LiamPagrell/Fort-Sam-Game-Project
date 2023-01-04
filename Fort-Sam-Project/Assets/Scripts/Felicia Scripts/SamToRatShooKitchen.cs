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
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(0.3f);
        GameObject.Find("Sam_placeholder").GetComponent<Animator>().SetTrigger("ShooReact");
    }

        
}
