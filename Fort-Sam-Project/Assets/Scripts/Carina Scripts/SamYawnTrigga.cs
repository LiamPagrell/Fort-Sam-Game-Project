using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamYawnTrigga : MonoBehaviour
{
    Movement player;
    public GameObject bed;


    void Start()
    {
        player = FindObjectOfType<Movement>();

        GameObject.Find("Sam_placeholder").GetComponent<Animator>().Play("Yawn");
        player.gameObject.GetComponent<Movement>().enabled = false;
        Invoke("ResumeControl", 4.8f);
        bed.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
    }


    private void ResumeControl()
    {
        player.gameObject.GetComponent<Movement>().enabled = true;
        bed.gameObject.GetComponent<PolygonCollider2D>().enabled = true;
    }
}
