using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamYawnTrigga : MonoBehaviour


{
    Movement player;


    void Start()
    {
        player = FindObjectOfType<Movement>();

        GameObject.Find("Sam_placeholder").GetComponent<Animator>().Play("Yawn");
        player.gameObject.GetComponent<Movement>().enabled = false;
        Invoke("ResumeControl", 4.8f);
    }


    private void ResumeControl()
    {
        player.gameObject.GetComponent<Movement>().enabled = true;
    }
}
