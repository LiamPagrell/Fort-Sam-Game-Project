using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity.VisualScripting;
using System.Net.Sockets;
using UnityEngine.UI;
using UnityEngine.Windows;

public class GreenCrossword : MonoBehaviour
{
    [SerializeField] TMP_InputField InputEgg;


    bool foundCode;
    void Start()
    {
        
    }

    void Update()
    {
        if (!foundCode)
        {
            CheckCodeEgg();
            Debug.Log("workin");
            Debug.Log(InputEgg.text);
        }
    }
    public void CheckCodeEgg()
    {
        if (InputEgg.text == "egg")
        {
            foundCode = true;
            Debug.Log("rightCodeEgg");
            StartCoroutine(WinCLosePanel());
        }
    }
    IEnumerator WinCLosePanel()
    {
     yield return new WaitForSeconds(0.5f);
        //GetComponentInChildren<Text>().color = Color.green;
        //TextMeshProUGUI greenEgg = InputEgg.transform.Find("Text").GetComponent<TextMeshProUGUI>();
        //greenEgg.color = Color.green;
        InputEgg.DeactivateInputField();
        InputEgg.enabled = false;

    }

}
