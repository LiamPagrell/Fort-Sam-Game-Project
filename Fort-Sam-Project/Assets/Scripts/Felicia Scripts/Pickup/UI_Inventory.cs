using System;
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
            Debug.Log("förstört barn");

        }

        foreach (Item item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSloTemplate.gameObject, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);

            Image image = itemSlotRectTransform.GetComponentInChildren<Image>();
            image.sprite = item.GetSprite();

            Button button = itemSlotRectTransform.GetComponentInChildren<Button>();
            button.onClick.AddListener(() => GetActivaion(item, itemSlotRectTransform));
        }
    }

    private void GetActivaion(Item item, RectTransform itemSlotRectTransform)
    {
        switch (item.itemType)
        {
            case ItemType.Skruvmejsel: Screwdriver(itemSlotRectTransform); break;
            case ItemType.Ball: Ball(itemSlotRectTransform); break;
            case ItemType.Remote: Remote(itemSlotRectTransform); break;
            default:
                break;

                //case ItemType.Remote: return ItemAssets.Instance.remote;
                //case ItemType.Ball: return ItemAssets.Instance.ball;
                //case ItemType.BedCoverAndPillow: return ItemAssets.Instance.bedcoverandpillow;
                //case ItemType.Book: return ItemAssets.Instance.book;
        }
    }

    private void Screwdriver(RectTransform itemSlotRectTransform)
    {
        Debug.Log("klickat på mejsel UI");
        Destroy(itemSlotRectTransform.gameObject);
    }

    private void Ball(RectTransform itemSlotRectTransform)
    {
        Debug.Log("klickat på boll UI");
        Destroy(itemSlotRectTransform.gameObject);
    }

    private void Remote(RectTransform itemSlotRectTransform)
    {
        Debug.Log("funkar detta?");
        Destroy(itemSlotRectTransform.gameObject);
        GameObject.Find("Helicopter_placeholder").GetComponent<Animator>().SetTrigger("Fly");
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
