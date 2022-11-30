using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorInteractable : MonoBehaviour
{

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;


    public void OnMouseOver()
    {
        if (CompareTag("Interactable"))
        {
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        }
    }

    public void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
