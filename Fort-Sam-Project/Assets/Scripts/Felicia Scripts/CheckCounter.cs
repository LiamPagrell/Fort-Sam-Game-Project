using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class CheckCounter : MonoBehaviour
{
    public GameObject blanketCheckMark;
    public GameObject pillowCheckMark;

    void Start()
    {
        if (PlayerPrefs.GetInt("PillowAndBlanket_Placeholder") == 1)
        {
            blanketCheckMark.SetActive(true);
        }
    }
}
