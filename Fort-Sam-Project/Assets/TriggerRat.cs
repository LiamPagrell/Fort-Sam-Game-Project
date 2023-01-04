using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRat : MonoBehaviour
{
    public GameObject rat;
    PickupBehaviour pockpick;
    // Start is called before the first frame update
    void Start()
    {
        pockpick = FindObjectOfType<PickupBehaviour>();
    }

    public void OnTriggerEnter2D(Collider2D coleslaw)
    {
        if (pockpick.GotCheese == true)
        {
            if (coleslaw.CompareTag("Player"))
            {
                rat.gameObject.GetComponent<Animator>().SetTrigger("Consume");
                rat.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            }

        }

        else
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
