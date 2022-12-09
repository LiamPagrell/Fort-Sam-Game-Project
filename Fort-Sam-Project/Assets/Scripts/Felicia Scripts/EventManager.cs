using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class EventManager : MonoBehaviour, IPointerClickHandler
{
    
    public static event Action Event;

    private void Update()
    {
   
    }


    public void OnPointerClick (PointerEventData data)
    {
        Debug.Log("hejsan");
        ClickOnThings(data.pointerCurrentRaycast.gameObject.GetComponent<ItemWorld>().itemType, data.pointerCurrentRaycast.gameObject);
    }

    private void ClickOnThings(ItemType itemType, GameObject clickedObject)
    {
        Debug.Log("hejsan");


        switch (itemType)
        {
            //case ItemType.Ball: Ball(clickedObject); break;
            default:
                break;

                //case ItemType.Remote: return ItemAssets.Instance.remote;
                //case ItemType.Ball: return ItemAssets.Instance.ball;
                //case ItemType.BedCoverAndPillow: return ItemAssets.Instance.bedcoverandpillow;
                //case ItemType.Book: return ItemAssets.Instance.book;
        }
    }

    private void Ball(GameObject clickedObject)
    {
        Debug.Log("hejsan");
        clickedObject.GetComponent<Animator>().SetTrigger("PickUp");
    }

}
