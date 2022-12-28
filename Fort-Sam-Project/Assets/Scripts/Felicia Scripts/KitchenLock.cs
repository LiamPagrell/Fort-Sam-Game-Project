using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KitchenLock : MonoBehaviour
{
    [SerializeField] TMP_InputField Input;
    void Start()
    {
        
    }

   
    void Update()
    {
        CheckCode();
    }
    public void CheckCode()
    {
        if (Input.text == "krita")
        {
            StartCoroutine(WinCLosePanel());
        }
    }
    IEnumerator WinCLosePanel()
    {
        yield return new WaitForSeconds(0.5f);
        this.gameObject.SetActive(false);

    }
}
