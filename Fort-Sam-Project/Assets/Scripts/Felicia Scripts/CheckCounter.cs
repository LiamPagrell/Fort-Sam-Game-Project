using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class CheckCounter : MonoBehaviour
{
    public GameObject blanketCheckMark;
    public GameObject pillowCheckMark;
    public GameObject LightsCheckMark;


    void Start()
    {
        if (PlayerPrefs.GetInt("PillowAndBlanket_Placeholder") == 1)
        {
            blanketCheckMark.SetActive(true);
            Debug.Log("Key1");
        }

        if (PlayerPrefs.GetInt("Couch") == 1)
        {
            pillowCheckMark.SetActive(true);
            Debug.Log("Key2");
        }

        if (PlayerPrefs.GetInt("FortLights") == 1)
        {
            LightsCheckMark.SetActive(true);
            Debug.Log("Key3");
        }
    }
}