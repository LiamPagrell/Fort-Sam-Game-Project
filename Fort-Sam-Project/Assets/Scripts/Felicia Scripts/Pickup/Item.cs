using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType
    {
        Skruvmejsel,
        Remote,
        Ball,
    }
    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Skruvmejsel:  return ItemAssets.Instance.skruvmejsel;
            case ItemType.Remote:   return ItemAssets.Instance.remote;
            case ItemType.Ball:     return ItemAssets.Instance.ball;
        }
    }
   
}
