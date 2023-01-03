using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity.VisualScripting;
using System.Net.Sockets;
using UnityEngine.UI;
using UnityEngine.Windows;
using UnityEngine.UIElements;

public class GreenCrossword : MonoBehaviour
{
    [SerializeField] TMP_InputField InputEgg;
    [SerializeField] TextMeshProUGUI GreenEggText;
    [SerializeField] TMP_InputField InputPig;
    [SerializeField] TextMeshProUGUI GreenPigText;
    [SerializeField] TMP_InputField InputLamb;
    [SerializeField] TextMeshProUGUI GreenLambText;
    [SerializeField] TMP_InputField InputGlobe;
    [SerializeField] TextMeshProUGUI GreenGlobeText;
    [SerializeField] TMP_InputField InputBeet;
    [SerializeField] TextMeshProUGUI GreenBeetText;
    [SerializeField] TMP_InputField InputPrice;
    [SerializeField] TextMeshProUGUI GreenPriceText;
    [SerializeField] TMP_InputField InputLatte;
    [SerializeField] TextMeshProUGUI GreenLatteText;
    public SoundManager soundManager;



    bool foundCodeLamb;
    bool foundCodeGlobe;
    bool foundCodeBeet;
    bool foundCodePrice;
    bool foundCodeLatte;
    void Start()
    {
        InputEgg.onValueChanged.AddListener(delegate { CheckCodeEgg(); });
        InputPig.onValueChanged.AddListener(delegate { CheckCodePig(); });
    }

    void Update()
    {
        if (!foundCodeLamb)
        {
            CheckCodeLamb();  
        }

        if (!foundCodeGlobe)
        {
            CheckCodeGlobe();
        }

        if (!foundCodeBeet)
        {
            CheckCodeBeet();
        }

        if (!foundCodePrice)
        {
            CheckCodePrice();
        }

        if (!foundCodeLatte)
        {
            CheckCodeLatte();
        }
    }
    public void CheckCodeEgg()
    {
        if (InputEgg.text == "egg")
        {
            StartCoroutine(WinCLosePanel(InputEgg, GreenEggText));
        }
    }

    public void CheckCodePig()
    {
        if (InputPig.text == "pig")
        {
            StartCoroutine(WinCLosePanel(InputPig, GreenPigText));
        }
    }

    public void CheckCodeLamb()
    {
        if (InputLamb.text == "lamb")
        {
            foundCodeLamb = true;
            StartCoroutine(WinCLosePanelLamb());
        }
    }

    public void CheckCodeGlobe()
    {
        if (InputGlobe.text == "globe")
        {
            foundCodeGlobe = true;
            StartCoroutine(WinCLosePanelGlobe());
        }
    }

    public void CheckCodeBeet()
    {
        if (InputBeet.text == "beet")
        {
            foundCodeBeet = true;
            StartCoroutine(WinCLosePanelBeet());
        }
    }

    public void CheckCodePrice()
    {
        if (InputPrice.text == "price")
        {
            foundCodePrice = true;
            StartCoroutine(WinCLosePanelPrice());
        }
    }

    public void CheckCodeLatte()
    {
        if (InputLatte.text == "latte")
        {
            foundCodeLatte = true;
            StartCoroutine(WinCLosePanelLatte());
        }
    }
    IEnumerator WinCLosePanel(TMP_InputField inputField, TextMeshProUGUI greenText)
    {
        yield return new WaitForSeconds(0.5f);
        greenText.color = new Color(37, 73, 59);
        inputField.DeactivateInputField();
        inputField.enabled = false;
        soundManager.Treasure();
    }

    IEnumerator WinCLosePanelLamb()
    {
        yield return new WaitForSeconds(0.5f);
        GreenLambText.color = new Color(37, 73, 59);
        InputLamb.DeactivateInputField();
        InputLamb.enabled = false;
        soundManager.Treasure();

    }

    IEnumerator WinCLosePanelGlobe()
    {
        yield return new WaitForSeconds(0.5f);
        GreenGlobeText.color = new Color(37, 73, 59);
        InputGlobe.DeactivateInputField();
        InputGlobe.enabled = false;
        soundManager.Treasure();

    }

    IEnumerator WinCLosePanelBeet()
    {
        yield return new WaitForSeconds(0.5f);
        GreenBeetText.color = new Color(37, 73, 59);
        InputBeet.DeactivateInputField();
        InputBeet.enabled = false;
        soundManager.Treasure();

    }

    IEnumerator WinCLosePanelPrice()
    {
        yield return new WaitForSeconds(0.5f);
        GreenPriceText.color = new Color(37, 73, 59);
        InputPrice.DeactivateInputField();
        InputPrice.enabled = false;
        soundManager.Treasure();

    }

    IEnumerator WinCLosePanelLatte()
    {
        yield return new WaitForSeconds(0.5f);
        GreenLatteText.color = new Color(37, 73, 59);
        InputLatte.DeactivateInputField();
        InputLatte.enabled = false;
        soundManager.Treasure();

    }

}
