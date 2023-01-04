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
        //this.gameObject.SetActive(false); ///Needs removal probably
        locket.gameObject.SetActive(false);
        IntractablesCollScript.gameObject.GetComponent<TurnOffCollidersScript>().TurnOffColls();
        //fridge.gameObject.SetActive(true); ///Needs removal probably
        cheese.gameObject.GetComponent<Animator>().SetTrigger("cheese");
        fridge.gameObject.GetComponent<Animator>().SetTrigger("openSesame");
        frigglock.gameObject.GetComponent<Animator>().SetTrigger("babyfelldown");
        //yield return new WaitForSeconds(1f); ///Needs removal probably
        ///konfetti.gameObject.SetActive(true); ///[Needs to be uncommented when in use]
        soundManager.Treasure();
        //fridge.gameObject.SetActive(false); ///Needs removal probably
        //rat.gameObject.GetComponent<Animator>().SetTrigger("RatRunnin"); ///Needs removal probably
        //Camera.main.GetComponent<CameraFollow>().TemporaryFollow(transform, 3); ///Needs removal probably
        //rat.gameObject.GetComponent<BoxCollider2D>().enabled= false; ///Needs removal probably
        //rat.gameObject.GetComponent<CapsuleCollider2D>().enabled = false; ///Needs removal probably
        GameObject.Find("kitchenlock").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled = true;
        inputField.gameObject.SetActive(false);

    }

    
}
