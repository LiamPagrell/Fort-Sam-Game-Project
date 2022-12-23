using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public Animator animator;
    public float transitionDelayTime = 0.5f;

    void Awake()
    {
        animator = GameObject.Find("Transition").GetComponent<Animator>();
    }

    public void LoadLevel(int index)
    {
        StartCoroutine(DelayLoadLevel(index));
    }

    IEnumerator DelayLoadLevel(int index)
    {
        animator.SetTrigger("TriggerTransition");
        yield return new WaitForSeconds(transitionDelayTime);
        SceneManager.LoadScene(index);
    }
}
