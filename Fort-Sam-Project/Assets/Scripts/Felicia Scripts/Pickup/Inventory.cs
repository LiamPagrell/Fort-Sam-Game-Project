//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using static UnityEditor.Progress;

//public class Inventory 
//{
//    private List<Item> itemList;

//    public Inventory()
//    {
//        itemList = new List<Item>();

//        AddItem(new Item { itemType = Item.ItemType.Battery, amount = 1});
//        AddItem(new Item { itemType = Item.ItemType.Remote, amount = 1 });
//        AddItem(new Item { itemType = Item.ItemType.Ball, amount = 1 });
//        Debug.Log("Inventory");
//    }

//    public void AddItem(Item item)
//    {
//        itemList.Add(item);
//    }
//    public List<Item> GetItemList()
//    {
//        return itemList;
//    }
//}
