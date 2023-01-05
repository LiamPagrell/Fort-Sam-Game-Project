using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity.VisualScripting;
using System.Net.Sockets;
using UnityEngine.UI;
using UnityEngine.Windows;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI;

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
    public GameObject korsord;
    Movement player;
    string locked;
    string locked1;
    string locked2;
    string locked3;
    string locked4;
    string locked5;
    string locked6;
    TurnOffCollidersScript IntractablesCollScript;

    void Start()
    {
        player = FindObjectOfType<Movement>();
        IntractablesCollScript = FindObjectOfType<TurnOffCollidersScript>();
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
        if (locked6.Length > 2)
        {
            char[] chars = InputEgg.text.ToCharArray();
            string newString = chars[0].ToString() + chars[1];
            InputEgg.text = newString;
        }
    }

    public void CheckCodePig()
    {
        if (InputPig.text == "pig")
        {
            StartCoroutine(WinCLosePanel(InputPig, GreenPigText));
        }
        if (locked5.Length > 2)
        {
            char[] chars = InputPig.text.ToCharArray();
            string newString = chars[0].ToString() + chars[1];
            InputPig.text = newString;
        }
    }

    public void CheckCodeLamb()
    {
        if (InputLamb.text == "lamb")
        {
            StartCoroutine(WinCLosePanel(InputLamb, GreenLambText));
        }
        if (locked4.Length > 3)
        {
            char[] chars = InputLamb.text.ToCharArray();
            string newString = chars[0].ToString() + chars[1] + chars[2];
            InputLamb.text = newString;
        }
    }

    public void CheckCodeGlobe()
    {
        if (InputGlobe.text == "globe")
        {
            StartCoroutine(WinCLosePanel(InputGlobe, GreenGlobeText));
        }
        if (locked3.Length > 4)
        {
            char[] chars = InputGlobe.text.ToCharArray();
            string newString = chars[0].ToString() + chars[1] + chars[2] + chars[3];
            InputGlobe.text = newString;
        }
    }

    public void CheckCodeBeet()
    {
        if (InputBeet.text == "beet")
        {
            StartCoroutine(WinCLosePanel(InputBeet, GreenBeetText));
        }
        if (locked2.Length > 3)
        {
            char[] chars = InputBeet.text.ToCharArray();
            string newString = chars[0].ToString() + chars[1] + chars[2];
            InputBeet.text = newString;
        }
    }

    public void CheckCodePrice()
    {
        if (InputPrice.text == "price")
        {
            StartCoroutine(WinCLosePanel(InputPrice, GreenPriceText ));
        }
        if (locked1.Length > 4)
        {
            char[] chars = InputPrice.text.ToCharArray();
            string newString = chars[0].ToString() + chars[1] + chars[2] + chars[3];
            InputPrice.text = newString;
        }
    }

    public void CheckCodeLatte()
    {
        if (InputLatte.text == "latte")
        {
            StartCoroutine(WinCLosePanel(InputLatte, GreenLatteText));
        }


        if (locked.Length > 4)
        {
            char[] chars = InputLatte.text.ToCharArray();
            string newString = chars[0].ToString() + chars[1] + chars[2] + chars[3];
            InputLatte.text = newString;
        }
    }

    public void EverythingRight()
    {
        if(InputLatte.text == "latte"& InputPrice.text == "price" & InputBeet.text == "beet" & InputGlobe.text == "globe"& InputLamb.text == "lamb"& InputPig.text == "pig"& InputEgg.text == "egg")
        {
            soundManager.Treasure();
            konfetti.gameObject.SetActive(true);    
            korsord.SetActive(false);
            IntractablesCollScript.gameObject.GetComponent<TurnOffCollidersScript>().TurnOnColls();
        }
    }
    IEnumerator WinCLosePanel(TMP_InputField inputField, TextMeshProUGUI greenText)
    {
        yield return new WaitForSecondsRealtime(0.5f);
        player.gameObject.GetComponent<Movement>().enabled = true;
        player.gameObject.GetComponent<Movement>().StartMovement();
        greenText.color = new Color(37, 73, 59);
        inputField.DeactivateInputField();
        inputField.enabled = false;
        soundManager.Treasure();
        EverythingRight();
    }
    private void Update()
    {
        locked = InputLatte.text;
        locked1 = InputPrice.text;
        locked2 = InputBeet.text;
        locked3 = InputGlobe.text;
        locked4 = InputLamb.text;
        locked5 = InputPig.text;
        locked6 = InputEgg.text;
    }

}
