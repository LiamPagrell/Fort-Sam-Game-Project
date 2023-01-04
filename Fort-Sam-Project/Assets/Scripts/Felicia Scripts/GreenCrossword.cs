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
    public ParticleSystem konfetti;

    void Start()
    {
        InputEgg.onValueChanged.AddListener(delegate { CheckCodeEgg(); });
        InputPig.onValueChanged.AddListener(delegate { CheckCodePig(); });
        InputLamb.onValueChanged.AddListener(delegate { CheckCodeLamb(); });
        InputGlobe.onValueChanged.AddListener(delegate { CheckCodeGlobe(); });
        InputBeet.onValueChanged.AddListener(delegate { CheckCodeBeet(); });
        InputPrice.onValueChanged.AddListener(delegate { CheckCodePrice(); });
        InputLatte.onValueChanged.AddListener(delegate { CheckCodeLatte(); });
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
            StartCoroutine(WinCLosePanel(InputLamb, GreenLambText));
        }
    }

    public void CheckCodeGlobe()
    {
        if (InputGlobe.text == "globe")
        {
            StartCoroutine(WinCLosePanel(InputGlobe, GreenGlobeText));
        }
    }

    public void CheckCodeBeet()
    {
        if (InputBeet.text == "beet")
        {
            StartCoroutine(WinCLosePanel(InputBeet, GreenBeetText));
        }
    }

    public void CheckCodePrice()
    {
        if (InputPrice.text == "price")
        {
            StartCoroutine(WinCLosePanel(InputPrice, GreenPriceText ));
        }
    }

    public void CheckCodeLatte()
    {
        if (InputLatte.text == "latte")
        {
            StartCoroutine(WinCLosePanel(InputLatte, GreenLatteText));
        }
    }

    public void EverythingRight()
    {
        if(InputLatte.text == "latte"& InputPrice.text == "price" & InputBeet.text == "beet" & InputGlobe.text == "globe"& InputLamb.text == "lamb"& InputPig.text == "pig"& InputEgg.text == "egg")
        {
            soundManager.Treasure();
            konfetti.gameObject.SetActive(true);

        }
    }
    IEnumerator WinCLosePanel(TMP_InputField inputField, TextMeshProUGUI greenText)
    {
        yield return new WaitForSecondsRealtime(0.5f);
        greenText.color = new Color(37, 73, 59);
        inputField.DeactivateInputField();
        inputField.enabled = false;
        soundManager.Treasure();
    }
}
