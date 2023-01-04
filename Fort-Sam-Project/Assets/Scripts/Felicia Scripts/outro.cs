using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class outro : MonoBehaviour
{

    [SerializeField] Animator animator;
    [SerializeField] GameObject transitionImage;
    [SerializeField] GameObject transitionText;

    // Start is called before the first frame update
    void Start()
    {

        animator.SetTrigger("TriggerTransition");
        LoadEndScene();

    }
    public void LoadEndScene()
    {

        StartCoroutine(FortFinished());
    }

    IEnumerator FortFinished()
    {
 

        yield return new WaitForSecondsRealtime(2f);
   
        transitionText.SetActive(true);
        //transitionImage.SetActive(false);
        yield return new WaitForSecondsRealtime(3f);
        animator.SetTrigger("FadeIn");
        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene("Outro2");


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
