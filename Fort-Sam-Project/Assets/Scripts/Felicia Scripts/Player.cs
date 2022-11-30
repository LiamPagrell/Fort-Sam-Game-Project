using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.FlowStateWidget;

public class Player : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] private UI_Inventory uiInventory;
         private void Awake()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
        ItemWorld.SpawnItemWorld(new Vector3(20,20),new Item{itemType = Item.ItemType.Remote, amount = 1});
        ItemWorld.SpawnItemWorld(new Vector3(-20,20),new Item{itemType = Item.ItemType.Ball, amount = 1 });
        ItemWorld.SpawnItemWorld(new Vector3(0,-20),new Item{itemType = Item.ItemType.Skruvmejsel, amount = 1 });

    }
}
