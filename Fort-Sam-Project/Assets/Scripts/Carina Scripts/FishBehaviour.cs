using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBehaviour : MonoBehaviour
{

    private void Update()
    {
        AngryFish();
    }

    public void AngryFish()
    {
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
