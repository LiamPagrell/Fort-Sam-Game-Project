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
    public SoundManager soundManager;
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
            //case ItemType.Skruvmejsel: Screwdriver(itemSlotRectTransform); break;
            //case ItemType.Ball: Ball(itemSlotRectTransform); break;
            case ItemType.Remote: 
                Remote(itemSlotRectTransform);
                inventory.Remove(item);
                break;
            case ItemType.ToyFish:
                ToyFish(itemSlotRectTransform);
                inventory.Remove(item);
                break;
            default:
                break;

                //case ItemType.Remote: return ItemAssets.Instance.remote;
                //case ItemType.Ball: return ItemAssets.Instance.ball;
                //case ItemType.BedCoverAndPillow: return ItemAssets.Instance.bedcoverandpillow;
                //case ItemType.Book: return ItemAssets.Instance.book;
        }
    }

    //private void Screwdriver(RectTransform itemSlotRectTransform)
    //{
    //    Debug.Log("klickat på mejsel UI");
    //    Destroy(itemSlotRectTransform.gameObject);
    //}

    //private void Ball(RectTransform itemSlotRectTransform)
    //{
    //    Debug.Log("klickat på boll UI");
    //    Destroy(itemSlotRectTransform.gameObject);
    //}

    private void Remote(RectTransform itemSlotRectTransform)
    {
        StartCoroutine(wait());

        Destroy(itemSlotRectTransform.gameObject);

        GameObject.Find("Helicopter_placeholder").GetComponent<Animator>().SetTrigger("Fly");
        soundManager.Helikopter();
        IEnumerator wait()
        {
            yield return new WaitForSeconds(3f);
            GameObject.Find("Robot_Eyes").GetComponent<Animator>().SetTrigger("Robo");
            soundManager.Robo();
        }
        GameObject.Find("Cat").GetComponent<Animator>().SetTrigger("CatConActive");
        GameObject.Find("BigWhiskers").GetComponent<Animator>().SetTrigger("NeedConRat");
        GameObject.Find("Robot").GetComponent<Animator>().SetTrigger("TheWobble");
        //GameObject.Find("Cat").GetComponent<Animator>().SetTrigger("CatAnim");
        //GameObject.Find("BigWhiskers").GetComponent<Animator>().SetTrigger("RatAnim");
        //Debug.Log("Poopyman");
    }

    public void ToyFish(RectTransform itemSlotRectTransform)
    {
        Destroy(itemSlotRectTransform.gameObject);
        GameObject.Find("LoveinterestFish (1)").GetComponent<Animator>().SetTrigger("ToyFishBowl");
        FindObjectOfType<GetKeyFromFishBowl>().KeyCanBePickuped();
        StartCoroutine(ToyWobble());

        IEnumerator ToyWobble()
        {
            yield return new WaitForSeconds(1f);
            GameObject.Find("LoveinterestFish (1)").GetComponent<Animator>().SetTrigger("ToyFishWobble");

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
