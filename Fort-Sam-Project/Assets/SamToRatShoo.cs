using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamToRatShoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("BigRat"))
        {
            GameObject.Find("BigWhiskers").GetComponent<Animator>().SetTrigger("RatShoo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
