using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToExit : MonoBehaviour
{
    public GameObject arrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("PointToExit").GetComponent<Animator>().SetTrigger("Point");

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
