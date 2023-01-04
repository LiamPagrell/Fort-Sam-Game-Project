using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffCollidersScript : MonoBehaviour
{
    Collider2D[] allColliders;
    // Start is called before the first frame update
    void Start()
    {
        allColliders = GameObject.Find("Interactibles").GetComponentsInChildren<Collider2D>();
    }

    // Update is called once per frame
    public void TurnOffColls()
    {
        //function to trun off alla colliders
        foreach (var collider in allColliders)
        {
            collider.enabled = false;
        }

    }
    public void TurnOnColls()
    {
        //function to trun on alla colliders
        foreach (var collider in allColliders)
        {
            collider.enabled = true;
        }

    }
}

