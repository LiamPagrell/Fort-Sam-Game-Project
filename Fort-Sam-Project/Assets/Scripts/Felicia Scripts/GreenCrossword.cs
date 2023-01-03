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



    bool foundCodeEgg;
    bool foundCodePig;
    bool foundCodeLamb;
    bool foundCodeGlobe;
    bool foundCodeBeet;
    bool foundCodePrice;
    bool foundCodeLatte;
    void Start()
    {

    }

    void Update()
    {
        if (!foundCodeEgg)
        {
            CheckCodeEgg();
        }

        if(!foundCodePig)
        {
          CheckCodePig();
        }

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
            foundCodeEgg = true;
            StartCoroutine(WinCLosePanelEgg());
        }
    }

    public void CheckCodePig()
    {
        if (InputPig.text == "pig")
        {
            foundCodePig = true;
            StartCoroutine(WinCLosePanelPig());
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
    IEnumerator WinCLosePanelEgg()
    {
        yield return new WaitForSeconds(0.5f);
        GreenEggText.color = new Color(37, 73, 59);
        InputEgg.DeactivateInputField();
        InputEgg.enabled = false;
        soundManager.Treasure();

    }

    IEnumerator WinCLosePanelPig()
    {
        yield return new WaitForSeconds(0.5f);
        GreenPigText.color = new Color(37, 73, 59);
        InputPig.DeactivateInputField();
        InputPig.enabled = false;
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
