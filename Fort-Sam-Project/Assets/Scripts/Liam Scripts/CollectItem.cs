using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : Interactable
{
    public Item myItem;
    public override void Interact ()
    {
        Debug.Log("Adding " + name + " to inventory");
        //InventoryManager.inm.itemHeld = myItem;
    } 
    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
