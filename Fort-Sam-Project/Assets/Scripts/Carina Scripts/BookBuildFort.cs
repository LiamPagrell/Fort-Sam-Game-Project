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
    public ParticleSystem konfetti;
    public GameObject player;

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
        //SceneManager.LoadScene("Credits");
        StartCoroutine(FortFinished());
    }

    IEnumerator FortFinished()
    {
        yield return new WaitForSeconds(0.4f);
        transitionImage.SetActive(true);
        animator.SetTrigger("TriggerTransition");
        yield return new WaitForSeconds(1f);
        pillowFort.SetActive(true);
        fortBook.SetActive(false);
        player.gameObject.GetComponent<Animator>().SetTrigger("Happy");
        konfetti.gameObject.SetActive(true);
        buildFortIconActivate.SetActive(false);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Outro");
     

    }
}
