using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehaviour : MonoBehaviour
{
    //[SerializeField] List<GameObject> pickItems = new List<GameObject>();
    Movement player;
    private static Inventory inventory;
    private static UI_Inventory uiInventory;

    float checkDistance;
    float pickUpDistance = 3.4f;

    void Start()
    {
        player = FindObjectOfType<Movement>();

        if (inventory == null)
        {
            inventory = new Inventory();
        }

        if (uiInventory == null)
        {
            uiInventory = FindObjectOfType<UI_Inventory>();
            uiInventory.SetInventory(inventory);
        }
    }

    private void OnMouseDown()
    {
        checkDistance = Vector2.Distance(this.transform.position, player.transform.position);

        if (Input.GetMouseButtonDown(0) && checkDistance < pickUpDistance && CompareTag("Interactable"))
        {
            Debug.Log("Mouse click!");
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

        //else if (Input.GetMouseButtonDown(0) && checkDistance < pickUpDistance && CompareTag("Pillow") && !isInteractable)
        //{
        //    isInteractable = true;
        //    Debug.Log("Mouse click!");
        //    Destroy(gameObject);
        //}
    }
}
