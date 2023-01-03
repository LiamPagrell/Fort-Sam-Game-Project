using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ExitToFoyer : MonoBehaviour
{
    public GameObject TransitionSam;
    public GameObject Characters;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Characters.GetComponent<Animator>().SetTrigger("TransitLiving");
            TransitionSam.GetComponent<Animator>().SetTrigger("TransitionLiving");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
