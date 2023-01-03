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
    public ParticleSystem konfetti;
    public SoundManager soundManager;
  

    void Start()
    {
        inputField.onValueChanged.AddListener(delegate { CheckCode(); });
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
        fridge.gameObject.SetActive(true);
        cheese.gameObject.GetComponent<Animator>().SetTrigger("cheese");
        //yield return new WaitForSeconds(1f); ///Needs removal probably
        //konfetti.gameObject.SetActive(true); ///Needs to be uncommented when in use
        soundManager.Treasure();
        //fridge.gameObject.SetActive(false);
        //rat.gameObject.GetComponent<Animator>().SetTrigger("RatRunnin");
        //Camera.main.GetComponent<CameraFollow>().TemporaryFollow(transform, 3); ///Needs removal probably
        rat.gameObject.GetComponent<BoxCollider2D>().enabled= false;
        rat.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
        FindObjectOfType<ShineScripts>().enabled = false;


        GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled = true;
        
        inputField.gameObject.SetActive(false);

    }

    
}
