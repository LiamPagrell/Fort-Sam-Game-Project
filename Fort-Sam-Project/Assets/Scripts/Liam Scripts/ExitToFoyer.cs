using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ExitToFoyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("TransitionSam").GetComponent<Animator>().SetTrigger("Transition");
            GameObject.Find("Characters").GetComponent<Animator>().SetTrigger("Transit");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
