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
            GetComponent<Animator>().Play("AngryFish");
        }
    }

    public void FishTransition()
    {
        GetComponent<Animator>().Play("FishTransition");
    }

    public void LoveFishy()
    {
        GetComponent<Animator>().Play("FishInLove");
    }
}
