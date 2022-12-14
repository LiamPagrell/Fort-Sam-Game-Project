using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemWorld : MonoBehaviour
{
    public ItemType itemType;
    private Item item;
    //private SpriteRenderer spriteRenderer;
    
    private void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
        
        SetItem(new Item { itemType = this.itemType, amount = 1 });
    }
    public void SetItem(Item item)
    {
        this.item = item;
        //spriteRenderer.sprite = item.GetSprite(); ///Prata med robert om detta d? jag antar att det kan vara anledningen till att v?rlds-sprites byts ut mot list sprites i manager
    }
    public Item GetItem()
    {
        return item;
    }

    public void DestroySelf() 
    {
        var colliders = GetComponents<Collider2D>();

        foreach (var item in colliders)
        {
            item.enabled = false;
        }

        Invoke(nameof(Die), 0.55f);
    }

    private void Die()
    {
        Destroy(gameObject);
    }

}
