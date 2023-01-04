using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRat : MonoBehaviour
{
    public GameObject rat;
    public GameObject player;
   // public PickupBehaviour pockpick;
    public UI_Inventory UI_Inv;
    // Start is called before the first frame update

    public void OnTriggerEnter2D(Collider2D coleslaw)
    {
        if (coleslaw.CompareTag("Player"))
        {
            if (UI_Inv.GotCheese == true)
            {
                rat.gameObject.GetComponent<Animator>().SetTrigger("Consume");
                rat.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
                rat.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                player.gameObject.GetComponent<Animator>().SetBool("ShooActive", false);
                player.gameObject.GetComponent<Animator>().SetTrigger("PickingUpLow");
                Invoke(nameof(BoxOn), 3f);
            }
            
            else
            {
                return;
            }
        }

       
    }

    public void BoxOn()
    {
        rat.gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
