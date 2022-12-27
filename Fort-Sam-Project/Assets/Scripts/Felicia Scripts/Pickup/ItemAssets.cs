using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance
    {
        get; private set;
    }

    private void Awake()
    {
        Instance = this;
    }

    public Transform pfItemWorld;

    //public Sprite skruvmejsel;
    public Sprite remote;
    //public Sprite ball;
   // public Sprite bedcoverandpillow;
    public Sprite book;
    public Sprite cheese;
}
