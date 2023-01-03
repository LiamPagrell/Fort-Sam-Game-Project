using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableFort : MonoBehaviour
{
    string saveKey;
    private void Start()
    {
        saveKey = gameObject.name;

        //We have been picked up, remove us.
        if (PlayerPrefs.GetInt(saveKey) == 1)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        gameObject.SetActive(false);

        PlayerPrefs.SetInt(saveKey, 1);
    }
}
