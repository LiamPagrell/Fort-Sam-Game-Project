using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSocks : MonoBehaviour
{
    public CollectableCounter ColCount;


    private void Start()
    {
        //ColCount = GameObject.FindGameObjectWithTag("Insert Tag").GetComponent<CollectableCounter>();
    }

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Collectable"))
        {
            ColCount.AddSocks();
            Destroy(this.gameObject);
        }
    }
}