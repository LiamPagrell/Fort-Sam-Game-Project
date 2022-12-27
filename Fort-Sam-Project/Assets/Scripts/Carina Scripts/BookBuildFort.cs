using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BookBuildFort : MonoBehaviour
{
    [SerializeField] GameObject buildFortButton;
    public bool hasFortItems;

    void Start()
    {
        hasFortItems = false;
        buildFortButton.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetMouseButtonDown(0))
        {
            BuildFort(hasFortItems);
        }
    }

    public void BuildFort(bool hasFortItems)
    {
        if (hasFortItems)
        {
            buildFortButton.SetActive(true);
        }
    }

    public void LoadEndScene()
    {
        SceneManager.LoadScene("Credits");
    }
}
