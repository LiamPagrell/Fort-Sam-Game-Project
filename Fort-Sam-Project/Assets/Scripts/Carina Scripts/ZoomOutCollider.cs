using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOutCollider : MonoBehaviour
{



    public void OnMouseDown()
    {
        FishBowlInteract.FindObjectOfType<FishBowlInteract>().ZoomOutFishBowl();
    }
}
