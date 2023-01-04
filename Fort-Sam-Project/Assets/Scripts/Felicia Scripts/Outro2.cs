using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Outro2 : MonoBehaviour
{

    [SerializeField] Animator animator;
    [SerializeField] GameObject transitionImage;
    [SerializeField] GameObject transitionText;
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
        yield return new WaitForSecondsRealtime(1f);

        transitionText.SetActive(true);
        //transitionImage.SetActive(false);
        yield return new WaitForSecondsRealtime(3f);
        animator.SetTrigger("FadeIn");
        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene("Credits");


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
