using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRat : MonoBehaviour
{
    public GameObject rat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D coleslaw)
    {
        if(coleslaw.CompareTag("Pkayer"))
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        rat.gameObject.GetComponent<Animator>().SetTrigger("Consume");
    }
}