using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public GameObject lockPanel;
    // Start is called before the first frame update
    void Start()
    {

        
   

    }

     
    void Update()
    {
        
       
        
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (lockPanel.activeSelf)
                {
                    bool isActive = lockPanel.activeSelf;
                    lockPanel.SetActive(!isActive);
                    StartCoroutine(Wait());

                }

                else if (!lockPanel.activeSelf)
                {
                    SceneManager.LoadScene("Menu");

                }
            }

        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("Poopy1");
        
        
    }

}
