using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] private UI_Inventory uiInventory;
    private void Start()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
        //ItemWorld.SpawnItemWorld(new Vector3(20,20),new Item{itemType = Item.ItemType.Remote, amount = 1});
        //ItemWorld.SpawnItemWorld(new Vector3(-20,20),new Item{itemType = Item.ItemType.Ball, amount = 1 });
        //ItemWorld.SpawnItemWorld(new Vector3(0,-20),new Item{itemType = Item.ItemType.Skruvmejsel, amount = 1 });
    }

    private void OnMouseOver()
    {
        ItemWorld itemWorld = GetComponent<ItemWorld>();       
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(this.gameObject.name + "clicked");
            if (itemWorld != null)
            {
                //touching item
                inventory.AddItem(itemWorld.GetItem());
                uiInventory.RefreshInventoryItems();
                itemWorld.DestroySelf();
            }
        }
        
    }
}
