using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBehaviour : MonoBehaviour
{

    [SerializeField] GameObject keyCheck;

    private void Update()
    {
        if (keyCheck != null)
        {
            AngryFish();
        }
        else
        {
            LoveFishy();
        }

    }

    public void AngryFish()
    {
        {
            GetComponent<Animator>().SetTrigger("AngryFish");
        }
    }

    public void FishTransition()
    {
        GetComponent<Animator>().SetTrigger("FishChange");
    }

    public void LoveFishy()
    {
        GetComponent<Animator>().SetTrigger("FishLove");
    }
}
