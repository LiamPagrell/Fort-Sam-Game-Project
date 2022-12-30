using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class KitchenLock : MonoBehaviour
{
    [SerializeField] TMP_InputField Input;
    public GameObject fridge;
    public GameObject cheese;
    public GameObject locket;
    public GameObject rat;
    bool foundCode;

    void Start()
    {
        
    }

   
    void Update()
    {
       
        if (!foundCode)
        {
            CheckCode();
        }
        
    }
    public void CheckCode()
    {
        if (Input.text == "gilbert")
        {
            foundCode = true;
            Debug.Log("rightCode");
            StartCoroutine(WinCLosePanel());
        }
    }

    
    IEnumerator WinCLosePanel()
    {
        yield return new WaitForSeconds(0.5f);
        //this.gameObject.SetActive(false);
        locket.gameObject.SetActive(false);
        fridge.gameObject.SetActive(true);
        cheese.gameObject.GetComponent<Animator>().SetTrigger("cheese");
        yield return new WaitForSeconds(1f);
        Debug.Log("working");
        fridge.gameObject.SetActive(false);
        rat.gameObject.GetComponent<Animator>().SetTrigger("RatRunnin");
        rat.gameObject.GetComponent<BoxCollider2D>().enabled= false;

        Input.gameObject.SetActive(false);


    }

    
}
