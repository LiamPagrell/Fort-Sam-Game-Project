using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    //Skruvmejsel,
    Remote,
    //Ball,
    //BedCoverAndPillow,
    Book,
    Cheese,
    Key,
    ToyFish,
}

public class Item
{
    public ItemType itemType;
    public int amount;
    
    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            //case ItemType.Skruvmejsel:       return ItemAssets.Instance.skruvmejsel;
            case ItemType.Remote:            return ItemAssets.Instance.remote;
            //case ItemType.Ball:              return ItemAssets.Instance.ball;
            //case ItemType.BedCoverAndPillow: return null;
            case ItemType.Book:              return ItemAssets.Instance.book;
            case ItemType.Cheese: return ItemAssets.Instance.cheese;
            case ItemType.Key:               return ItemAssets.Instance.key;
            case ItemType.ToyFish:           return ItemAssets.Instance.toyFish;
        }
    }
}
