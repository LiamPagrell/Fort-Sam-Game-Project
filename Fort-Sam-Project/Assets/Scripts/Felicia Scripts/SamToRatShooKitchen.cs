using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamToRatShooKitchen : MonoBehaviour
{
    Movement player;

    public void Start()
    {
        player = FindObjectOfType<Movement>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BigRat"))
        {
            player.gameObject.GetComponent<Movement>().StopMovement();
            player.gameObject.GetComponent<Movement>().enabled = false;
            GameObject.Find("BigWhiskers").GetComponent<Animator>().SetTrigger("RatShoo");
            StartCoroutine(Wait());
            Invoke(nameof(StartMove), 1f);
        }
    }

    IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime(0.3f);
        GameObject.Find("Sam_placeholder").GetComponent<Animator>().SetTrigger("ShooReact");
    }

    public void StartMove()
    {
        player.gameObject.GetComponent<Movement>().enabled = true;
        player.gameObject.GetComponent<Movement>().StartMovement();
    }

        
}
