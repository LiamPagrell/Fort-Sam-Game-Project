using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorInteractable : MonoBehaviour
{

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = new Vector2(0, -1);

    private void Start()
    {
        //hotSpot = new Vector2(cursorTexture.width / 2, cursorTexture.height / 2);
    }

    public void OnMouseOver()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {

            if (CompareTag("Interactable"))
            {
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
            }

            if (CompareTag("Object"))
            {
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
            }
        }
    }

    public void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
