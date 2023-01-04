using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class KitchenLock : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    public GameObject fridge;
    public GameObject cheese;
    public GameObject locket;
    public GameObject rat;
    public GameObject frigglock;
    public ParticleSystem konfetti;
    public SoundManager soundManager;
    TurnOffCollidersScript IntractablesCollScript;


    void Start()
    {
        inputField.onValueChanged.AddListener(delegate { CheckCode(); });
        IntractablesCollScript = FindObjectOfType<TurnOffCollidersScript>();
    }

   
    public void CheckCode()
    {
        if (inputField.text == "gilbert")
        {
            Debug.Log("rightCode");
            StartCoroutine(WinCLosePanel());
        }
    }

    
    IEnumerator WinCLosePanel()
    {
        yield return new WaitForSeconds(0.5f);
        locket.gameObject.SetActive(false);
        IntractablesCollScript.gameObject.GetComponent<TurnOffCollidersScript>().TurnOnColls();
        cheese.gameObject.GetComponent<Animator>().SetTrigger("cheese");
        fridge.gameObject.GetComponent<Animator>().SetTrigger("openSesame");
        frigglock.gameObject.GetComponent<Animator>().SetTrigger("babyfelldown");
        konfetti.gameObject.SetActive(true); 
        GameObject.Find("kitchenlock").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled = true;
        soundManager.Treasure();
        inputField.gameObject.SetActive(false);

    }

    
}
