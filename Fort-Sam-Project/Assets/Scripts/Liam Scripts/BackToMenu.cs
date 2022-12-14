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
    // Start is called before the first frame update

    void Update()
    {
          
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (lockPanel.activeSelf)
                {
                    lockPanel.SetActive(!lockPanel.activeSelf);
                    StartCoroutine(Wait());
                    return;

                }

                if (calender.activeSelf)
                 {
                calender.SetActive(!calender.activeSelf);
                StartCoroutine(Wait());
                    return;

                 }

            if (drawing.activeSelf)
            {
                drawing.SetActive(!drawing.activeSelf);
                StartCoroutine(Wait());
                return;

            }
            if (framedPhoto.activeSelf)
            {
                framedPhoto.SetActive(!framedPhoto.activeSelf);
                StartCoroutine(Wait());
                return;

            }
            SceneManager.LoadScene("Menu");

               

          
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {

        }


    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
       
    }

}
