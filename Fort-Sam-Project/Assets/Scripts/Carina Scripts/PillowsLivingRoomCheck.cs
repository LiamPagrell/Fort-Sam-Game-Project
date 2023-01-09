using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillowsLivingRoomCheck : MonoBehaviour
{

    [SerializeField] GameObject bookMark;

    private void OnMouseDown()
    {
        bookMark.SetActive(true);
    }
}
