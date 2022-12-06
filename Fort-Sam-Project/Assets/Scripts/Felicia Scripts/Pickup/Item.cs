using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    Skruvmejsel,
    Remote,
    Ball,
    BedCoverAndPillow,
    Book,
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
            case ItemType.Skruvmejsel:       return ItemAssets.Instance.skruvmejsel;
            case ItemType.Remote:            return ItemAssets.Instance.remote;
            case ItemType.Ball:              return ItemAssets.Instance.ball;
            case ItemType.BedCoverAndPillow: return ItemAssets.Instance.bedcoverandpillow;
            case ItemType.Book:              return ItemAssets.Instance.book;
        }
    }
}
