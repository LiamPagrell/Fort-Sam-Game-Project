using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.U2D;

public class ItemWorld : MonoBehaviour
{
    public ItemType itemType;
    private Item item;
    private SpriteRenderer spriteRenderer;
    
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        SetItem(new Item { itemType = this.itemType, amount = 1 });
    }
    public void SetItem(Item item)
    {
        this.item = item;
        spriteRenderer.sprite = item.GetSprite();
    }
    public Item GetItem()
    {
        return item;
    }

    public void DestroySelf() 
    {
        Destroy(gameObject);
    }

}
