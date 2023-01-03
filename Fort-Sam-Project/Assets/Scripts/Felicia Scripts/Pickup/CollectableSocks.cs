using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectableSocks : MonoBehaviour
{
    string saveKey;

    private void Start()
    {
        //Calculate where to save our data
        saveKey = gameObject.name;

        //We have been picked up, remove us.
        if (PlayerPrefs.GetInt(saveKey) == 1)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        //picking up sock

        gameObject.SetActive(false);

        PlayerPrefs.SetInt(saveKey, 1);
    }
}
