using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBehaviour : MonoBehaviour
{

    Animator animator;

    private void Update()
    {
        AngryFish();
    }

    public void AngryFish()
    {

        //if (FindObjectOfType<FishBowlInteract>().isZoomed == true)
        {
            GetComponent<Animator>().SetTrigger("AngryFish");
        }
    }

    public void LoveFishy()
    {
        GetComponent<Animator>().SetTrigger("FishChange");
        GetComponent<Animator>().SetTrigger("FishLove");
    }
}
