using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBowlInteract : MonoBehaviour
{
    float zoomSize;
    Vector3 camPos;
    //float smoothSpeed = 2.0f;
    public bool isZoomed;
    Movement player;

    [SerializeField] GameObject fishBowl;
    [SerializeField] GameObject fishyFish;
    [SerializeField] GameObject backGroundFish;
    [SerializeField] GameObject keyCheck;
    [SerializeField] GameObject toyFish;
    public GameObject toyFishInShelf;

    void Start()
    {
        player = FindObjectOfType<Movement>();
        zoomSize = Camera.main.orthographicSize;
        camPos = Camera.main.transform.eulerAngles;
    }

    private void OnMouseDown()
    {
        if (!isZoomed)
        {
            FishBowlZoom();
        }
        else
        {
            ZoomOutFishBowl();
        }
    }

    public void FishBowlZoom()
    {
        // zoom in on the fishbowl
        Camera.main.transform.LookAt(transform.position, Vector2.zero);
        Camera.main.orthographicSize = zoomSize / 6;
        isZoomed = true;
        fishBowl.SetActive(true);
        fishyFish.SetActive(true);
        backGroundFish.SetActive(false);
        if (keyCheck == null)
        {
            toyFish.SetActive(true);
        }
    }

    public void ZoomOutFishBowl()
    {
        isZoomed = false;
        Camera.main.orthographicSize = zoomSize;
        Camera.main.transform.eulerAngles = camPos;
        fishBowl.SetActive(false);
        fishyFish.SetActive(false);
        backGroundFish.SetActive(true);
        toyFishInShelf.transform.gameObject.tag = "Interactable";
        toyFishInShelf.gameObject.GetComponent<BoxCollider2D>().enabled = true;
        if (keyCheck == null)
        {
            toyFish.SetActive(false);
        }
    }
}
