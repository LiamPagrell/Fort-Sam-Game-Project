using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class CheckCounter : MonoBehaviour
{
    public GameObject blanketCheckMark;
    public GameObject pillowCheckMark;
    public GameObject LightsCheckMark;
    //public GameObject toyFishInShelf;

    void Start()
    {
        if (PlayerPrefs.GetInt("PillowAndBlanket_Placeholder") == 1)
        {
            blanketCheckMark.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Couch") == 1)
        {
            pillowCheckMark.SetActive(true);
        }

        if (PlayerPrefs.GetInt("FortLights") == 1)
        {
            LightsCheckMark.SetActive(true);
        }
    }
}
