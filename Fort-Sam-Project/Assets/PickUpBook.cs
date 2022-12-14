using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBook : MonoBehaviour
{
    Movement player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Movement>();
    }

    private void Book()
    {
        player.gameObject.GetComponent<Animator>().SetTrigger("PickingUpLow");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
