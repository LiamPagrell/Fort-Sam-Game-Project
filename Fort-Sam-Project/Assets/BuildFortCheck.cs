using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildFortCheck : MonoBehaviour
{

    bool hasFortItems;
    [SerializeField] GameObject buttonToPress;

    void Start()
    {
        hasFortItems = false;
    }


    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //if (hasFortItems)
            {
                hasFortItems = true;
                buttonToPress.SetActive(true);

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    // build fort
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            buttonToPress.SetActive(false);
        }
    }
}
