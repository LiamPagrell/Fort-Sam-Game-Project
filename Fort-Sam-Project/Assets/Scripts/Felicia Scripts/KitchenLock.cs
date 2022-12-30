using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KitchenLock : MonoBehaviour
{
    [SerializeField] TMP_InputField Input;
    public GameObject fridge;
    public GameObject cheese;
    public GameObject locket;
    public GameObject rat;

    void Start()
    {
        
    }

   
    void Update()
    {
        CheckCode();
    }
    public void CheckCode()
    {
        if (Input.text == "gilbert")
        {
            StartCoroutine(WinCLosePanel());
        }
    }
    IEnumerator WinCLosePanel()
    {
        yield return new WaitForSeconds(0.5f);
        this.gameObject.SetActive(false);
        locket.gameObject.SetActive(false);
        fridge.SetActive(true);
        cheese.gameObject.GetComponent<Animator>().SetTrigger("cheese");
        yield return new WaitForSeconds(1f);
        fridge.gameObject.SetActive(false);
        //rat.gameObject.GetComponent<Animator>().SetTrigger("rat");


    }

    
}
