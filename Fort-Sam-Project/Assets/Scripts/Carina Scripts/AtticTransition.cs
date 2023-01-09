using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtticTransition : MonoBehaviour
{

    [SerializeField] GameObject goToAtticPopUp;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && goToAtticPopUp.activeSelf)
        {
            GoUpStairs();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            FindObjectOfType<DoorAtticTransition>().MoveFromDoor();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            goToAtticPopUp.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            goToAtticPopUp.SetActive(false);
        }
    }

    private void GoUpStairs()
    {
        StartCoroutine(StairsTransition());
    }

    IEnumerator StairsTransition()
    {
        yield return new WaitForSeconds(0.5f);
        goToAtticPopUp.SetActive(false);
        FindObjectOfType<DoorAtticTransition>().DoorClosed();
    }
}
