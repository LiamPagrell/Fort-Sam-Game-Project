using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BookBuildFort : MonoBehaviour
{
    [SerializeField] GameObject buildFortButton;
    [SerializeField] GameObject pillowFort;
    [SerializeField] Animator animator;
    [SerializeField] GameObject transitionImage;
    [SerializeField] GameObject fortBook;
    [SerializeField] GameObject buildFortIconActivate;
    [SerializeField] GameObject poofSmoke;
    [SerializeField] GameObject transitionText;
    public ParticleSystem konfetti;
    public GameObject player;
    public SoundManager soundManager;
    public bool hasFortItems;

    void Start()
    {
        hasFortItems = false;
        buildFortButton.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetMouseButtonDown(0))
        {
            BuildFort(hasFortItems);
        }
    }

    public void BuildFort(bool hasFortItems)
    {
        if (hasFortItems)
        {
            buildFortButton.SetActive(true);
        }
    }

    public void LoadEndScene()
    {
        StartCoroutine(FortFinished());
    }

    IEnumerator FortFinished()
    {
        yield return new WaitForSecondsRealtime(1f);
        transitionImage.SetActive(true);
        animator.SetTrigger("TriggerTransition");
        fortBook.SetActive(false);
        yield return new WaitForSecondsRealtime(2f);
        soundManager.Celebration();
        pillowFort.SetActive(true);
        poofSmoke.GetComponent<Animator>().Play("PoofSmoke");
        player.gameObject.GetComponent<Animator>().SetTrigger("Happy");
        konfetti.gameObject.SetActive(true);
        buildFortIconActivate.SetActive(false);
        yield return new WaitForSecondsRealtime(2f);
        transitionText.SetActive(false);
        animator.SetTrigger("FadeIn");
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene("Outro");
     

    }
}
