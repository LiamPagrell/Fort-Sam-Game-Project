using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private RectTransform itemSlotContainer;
    private Transform itemSloTemplate;
    //[SerializeField] GameObject[] itemSlots;
    //[SerializeField] GameObject itemPrefab;

    private void Awake()
    {
        itemSlotContainer = transform.Find("ItemSlotContainer").GetComponent<RectTransform>();
        itemSloTemplate = transform.Find("ItemSlotTemplate");
        itemSloTemplate.gameObject.SetActive(false);
    }
    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        RefreshInventoryItems();
    }

    public void RefreshInventoryItems()
    {
        foreach (Transform child in itemSlotContainer.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        foreach (Item item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSloTemplate.gameObject, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);

            Image image = itemSlotRectTransform.Find("Image").GetComponent<Image>();
            image.sprite = item.GetSprite();
        }

    }
        //private void RefreshInventoryItemsSAMUEL()
        //{
        //    int x = 0;
        //    int y = 0;
        //    float itemSlotCellSize = 30f;
        //    foreach (Item item in inventory.GetItemList())
        //    {
        //        RectTransform itemSlotRectTransform = Instantiate(itemSloTemplate.gameObject, itemSlotContainer).GetComponent<RectTransform>();
        //        itemSlotRectTransform.gameObject.SetActive(true);

        //        itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
        //        Image image = itemSlotRectTransform.Find("image").GetComponent<Image>();
        //        image.sprite = item.GetSprite();
        //        x++;
        //        if (x > 4)
        //        {
        //            x = 0;
        //            y++;
        //        }
        //    }
        //}
}
