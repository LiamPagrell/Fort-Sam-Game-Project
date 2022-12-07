using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
        spriteRenderer.sprite = item.GetSprite(); ///Prata med robert om detta då jag antar att det kan vara anledningen till att världs-sprites byts ut mot list sprites i manager
    }
    public Item GetItem()
    {
        return item;
    }

    public void DestroySelf() 
    {
        StartCoroutine(Die());

        IEnumerator Die()
        {
            yield return new WaitForSeconds(0.3f);
            Destroy(gameObject);
        }
    }

}
