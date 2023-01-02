using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyFromFishBowl : MonoBehaviour
{
    [SerializeField] GameObject preventKeyPickup;
    [SerializeField] GameObject fishBowlCollider;
 
    float waitTime = 1f;

    void Start()
    {

    }


    void Update()
    {
        
    }

    public void KeyCanBePickuped()
    {
        StartCoroutine(FishInLoveSequence());
    }

    IEnumerator FishInLoveSequence()
    {
        fishBowlCollider.gameObject.SetActive(false);

        Debug.Log("got here");
        yield return new WaitForSeconds(waitTime);
        FindObjectOfType<FishBehaviour>().LoveFishy();
        preventKeyPickup.gameObject.SetActive(false);
    }
}
