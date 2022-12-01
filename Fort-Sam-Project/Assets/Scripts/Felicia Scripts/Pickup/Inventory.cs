using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Inventory
{
    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();

        AddItem(new Item { itemType = ItemType.Skruvmejsel, amount = 1 });
        AddItem(new Item { itemType = ItemType.Remote, amount = 1 });
        //AddItem(new Item { itemType = Item.ItemType.Ball, amount = 1 });
    }

    public void AddItem(Item item)
    {
        itemList.Add(item);
    }

    public void Remove(Item item)
    {
        itemList.Remove(item);

        //was this the last one???
    }

    public bool hej()
    {
        var itemLeft = GameObject.FindObjectsOfType<ItemWorld>();

        if (itemLeft.Length == 0 && itemList.Count == 0)
	    {

	    }
        return true;
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }
}
