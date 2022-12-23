using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BednCover : MonoBehaviour
{
    public GameObject roboteyes;
    public GameObject cat;
    public GameObject rat;
    public GameObject bed;
    public GameObject remote;
    public GameObject checkmark;
    //[SerializeField] AudioSource clickSound;
    //public GameObject cat;
    Movement player;
    public SoundManager soundManager;
    public void BedCoverAndPillow()
    {
       bed.gameObject.GetComponent<Animator>().SetTrigger("Sheet");
        //GameObject.Find("Sam_Placeholder").GetComponent<Animator>().SetTrigger("PickingUpMedium");
        cat.gameObject.GetComponent<Animator>().SetTrigger("CatActive");
        rat.gameObject.GetComponent<Animator>().SetTrigger("RatRun");
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
