using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPickup : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            if (hit.collider != null && hit.collider.name == name)
            {
                Debug.Log("Item picked up");
            }*/
            
        

    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse click!");
        }
    }
}
