using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BednCover : MonoBehaviour
{
    //public GameObject roboteyes;
    //public GameObject cat;
    //public GameObject rat;
    //public GameObject bed;
    //public GameObject cat;
    public GameObject remote;
    public GameObject checkmark;
    public GameObject sam;
    //[SerializeField] AudioSource clickSound;
    //Movement player;
    public SoundManager soundManager;
    public void OnMouseDown()
    {
        //bed.gameObject.GetComponent<Animator>().SetTrigger("Sheet");
        Debug.Log("Start");
        sam.gameObject.GetComponent<Animator>().SetTrigger("PickingUpMedium");
        //GameObject.Find("Sam_Placeholder").GetComponent<Animator>().SetTrigger("PickingUpMedium");
        Debug.Log("Sam");
        GameObject.Find("PillowAndBlanket_Placeholder").GetComponent<Animator>().SetTrigger("Sheet");
        Debug.Log("Bed");
        GameObject.Find("Cat").GetComponent<Animator>().SetTrigger("CatActive");
        Debug.Log("Cat");
        GameObject.Find("BigWhiskers").GetComponent<Animator>().SetTrigger("RatRun");
        Debug.Log("Rat");
        //cat.gameObject.GetComponent<Animator>().SetTrigger("CatActive");
        //rat.gameObject.GetComponent<Animator>().SetTrigger("RatRun");

        soundManager.Cozies();
        soundManager.Purr();
        Debug.Log("täcke");
        checkmark.SetActive(true);
        Destroy(this.gameObject);
        //roboteyes.gameObject.GetComponent<Animator>().SetTrigger("CatJump");
        //cat.gameObject.GetComponent<Animator>().SetTrigger("CatAnim");
        //rat.gameObject.GetComponent<Animator>().SetTrigger("RatAnim");
        //StartCoroutine(wait());


    }
}
