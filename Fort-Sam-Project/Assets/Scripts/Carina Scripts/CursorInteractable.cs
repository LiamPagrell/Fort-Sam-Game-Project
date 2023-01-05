using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorInteractable : MonoBehaviour
{

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    private Vector2 hotSpot = new Vector2(0, 0);

    private void Start()
    {
        //hotSpot = new Vector2(cursorTexture.width / 2, cursorTexture.height / 2);
        hotSpot = new Vector2(45, 70);
    }

    public void OnMouseOver()
    {
        
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);


        //if (!EventSystem.current.IsPointerOverGameObject())
        //{

        //    if (CompareTag("Interactable"))
        //    {
        //        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        //    }

        //    if (CompareTag("Object"))
        //    {
        //        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        //    }
        //}
    }

    public void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    private void OnDestroy()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    private void OnDisable()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);

    }
}
