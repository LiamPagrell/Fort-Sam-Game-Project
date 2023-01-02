using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    [SerializeField] TMP_Text calm;
    [SerializeField] TMP_Text cicadas;
    [SerializeField] TMP_Text lightsOn;
    [SerializeField] GameObject house;
    [SerializeField] TMP_Text hearingVoices;
    [SerializeField] GameObject sam;
    [SerializeField] TMP_Text mom;
    [SerializeField] TMP_Text dad;
    [SerializeField] TMP_Text passed;
    int counter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            counter++;
            
        }

        switch (counter)
        {
            case 0: break;

            case 1: new WaitForSeconds(0.5f); calm.gameObject.SetActive(false); cicadas.gameObject.SetActive(true); break;

            case 2: cicadas.gameObject.SetActive(false); lightsOn.gameObject.SetActive(true); break;

            case 3:lightsOn.gameObject.SetActive(false); house.gameObject.SetActive(false); hearingVoices.gameObject.SetActive(true); sam.gameObject.SetActive(true); break;

            case 4:hearingVoices.gameObject.SetActive(false); mom.gameObject.SetActive(true); break;

            case 5: dad.gameObject.SetActive(true); mom.gameObject.SetActive(false); break;

            case 6: dad.gameObject.SetActive(false); passed.gameObject.SetActive(true); break;

            case 7: SceneManager.LoadScene("SamRoom"); break;

        }
    }
}
