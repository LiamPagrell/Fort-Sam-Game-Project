using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Outro2 : MonoBehaviour
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
        SceneManager.LoadScene("Credits");


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
