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

        //Invoke(nameof(Case7), 1f);
        //Invoke(nameof(Case8), 1f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            counter++;
            
        }

        switch (counter)
        {
            case 0: break;

            case 1:   StartCoroutine(Case1()); break;

            case 2:   StartCoroutine(Case2()); break;

            case 3: StartCoroutine(Case3()); break;

            case 4: StartCoroutine(Case4()); break;

            case 5: StartCoroutine(Case5()); break;

            case 6: StartCoroutine(Case6()); break;

            case 7: SceneManager.LoadScene("SamRoom"); break;

        }
        IEnumerator Case1()
        {
            yield return new WaitForSecondsRealtime(0.2f);
            calm.gameObject.SetActive(false);
            cicadas.gameObject.SetActive(true);
        }

        IEnumerator Case2()
        {
            yield return new WaitForSecondsRealtime(0.2f);
            cicadas.gameObject.SetActive(false);
           lightsOn.gameObject.SetActive(true);
        }

        IEnumerator Case3()
        {
            yield return new WaitForSecondsRealtime(0.2f);
            lightsOn.gameObject.SetActive(false);
            house.gameObject.SetActive(false);
            hearingVoices.gameObject.SetActive(true);
            sam.gameObject.SetActive(true);

        }
        IEnumerator Case4()
        {
            yield return new WaitForSecondsRealtime(0.2f);
            hearingVoices.gameObject.SetActive(false);
            mom.gameObject.SetActive(true);

        }
        IEnumerator Case5()
        {
            yield return new WaitForSecondsRealtime(0.2f);
            dad.gameObject.SetActive(true);
            mom.gameObject.SetActive(false);

        }
        IEnumerator Case6()
        {
            yield return new WaitForSecondsRealtime(0.2f);
            dad.gameObject.SetActive(false);
            passed.gameObject.SetActive(true);

        }

    }
    //public void Case7()
    //{
    //    name1.gameObject.SetActive(false);
    //    name2.gameObject.SetActive(true);
    //}
    //public void Case8()
    //{
    //    name1.gameObject.SetActive(false);
    //    name2.gameObject.SetActive(true);
    //}
}
