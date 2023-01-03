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
    [SerializeField] TextMeshProUGUI GreenEggText;


    bool foundCode;
    void Start()
    {

    }

    void Update()
    {
        if (!foundCode)
        {
            CheckCodeEgg();
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
        GreenEggText.color = Color.green;
        InputEgg.DeactivateInputField();
        InputEgg.enabled = false;

    }

}
