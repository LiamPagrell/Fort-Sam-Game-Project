using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyFromFishBowl : MonoBehaviour
{
    [SerializeField] GameObject preventKeyPickup;
    [SerializeField] GameObject fishBowlCollider;
    [SerializeField] GameObject keyCheck;

    float waitTime = 1f;

    void Start()
    {

    }


    void Update()
    {
        if (keyCheck == null)
        {
            AfterKeyPickuped();
        }
    }

    public void KeyCanBePickuped()
    {
        StartCoroutine(FishInLoveSequence());
    }

    IEnumerator FishInLoveSequence()
    {
        fishBowlCollider.gameObject.SetActive(false);

        yield return new WaitForSeconds(waitTime);
        FindObjectOfType<FishBehaviour>().FishTransition();
        yield return new WaitForSeconds(waitTime);
        FindObjectOfType<FishBehaviour>().LoveFishy();
        preventKeyPickup.gameObject.SetActive(false);
    }

    public void AfterKeyPickuped()
    {
        fishBowlCollider.gameObject.SetActive(true);
        
    }
}
