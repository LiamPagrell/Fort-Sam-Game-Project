using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class outro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoadEndScene();
    }
    public void LoadEndScene()
    {
        StartCoroutine(FortFinished());
    }

    IEnumerator FortFinished()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Outro2");


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
