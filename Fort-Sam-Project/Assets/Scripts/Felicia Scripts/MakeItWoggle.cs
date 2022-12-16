using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MakeItWoggle : MonoBehaviour, IPointerEnterHandler
{
    public RectTransform Button;
    void Start()
    {
       
        
        Button.GetComponent<Animator>().Play("Hover off");
        Debug.Log(this.gameObject.name + " Playing.");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().Play("Hover on");
        Debug.Log(this.gameObject.name + " Was Hovered.");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().Play("Hover off");
        Debug.Log(this.gameObject.name + " Hover off.");
    }
}
