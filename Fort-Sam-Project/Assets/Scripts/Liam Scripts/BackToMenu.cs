using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public GameObject lockPanel;
    public GameObject calender;
    public GameObject drawing;
    public GameObject framedPhoto;
    public GameObject wasd;
    // Start is called before the first frame update

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (wasd.activeSelf)
            {
                //wasd.SetActive(!wasd.activeSelf);
                GameObject.Find("wasd").GetComponent<Animator>().SetTrigger("ConFade");
                StartCoroutine(Waiter(wasd));
                return;

            }
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            if (wasd.activeSelf)
            {
                //wasd.SetActive(!wasd.activeSelf);
                GameObject.Find("wasd").GetComponent<Animator>().SetTrigger("ConFade");
                StartCoroutine(Waiter(wasd));
                return;

            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (wasd.activeSelf)
            {
                // wasd.SetActive(!wasd.activeSelf);
                GameObject.Find("wasd").GetComponent<Animator>().SetTrigger("ConFade");
                StartCoroutine(Waiter(wasd));
                return;

            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (wasd.activeSelf)
            {
                //wasd.SetActive(!wasd.activeSelf);
                GameObject.Find("wasd").GetComponent<Animator>().SetTrigger("ConFade");
                StartCoroutine(Waiter(wasd));
                return;

            }
        }

        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    if (lockPanel.activeSelf)
        //    {
        //        //lockPanel.SetActive(!lockPanel.activeSelf);
        //        StartCoroutine(Wait(lockPanel));
        //        return;

        //    }

        //    if (calender.activeSelf)
        //    {
        //        // calender.SetActive(!calender.activeSelf);
        //        StartCoroutine(Wait(calender));
        //        return;

        //    }

        //    if (drawing.activeSelf)
        //    {
        //        // drawing.SetActive(!drawing.activeSelf);
        //        StartCoroutine(Wait(drawing));
        //        return;

        //    }
        //    if (framedPhoto.activeSelf)
        //    {
        //        // framedPhoto.SetActive(!framedPhoto.activeSelf);
        //        StartCoroutine(Wait(framedPhoto));
        //        return;

        //    }

        //    PickupBehaviour.ResetInventory();
        //    SceneManager.LoadScene("Menu");




        //}

        if (Input.GetKeyDown(KeyCode.Escape))
        {

        }


    }

    //IEnumerator Wait(GameObject objectToTurnOff)
    //{
    //    yield return new WaitForSeconds(0.3f);
    //    objectToTurnOff.SetActive(false);
    //}

    IEnumerator Waiter(GameObject objectToTurnOff)
    {
        yield return new WaitForSeconds(1f);
        objectToTurnOff.SetActive(false);
    }

}
