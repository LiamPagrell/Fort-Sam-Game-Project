using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSamsRoom : MonoBehaviour
{

    private void OnMouseDown()
    {
        GetComponent<Animator>().SetTrigger("PetCat");
        FindObjectOfType<SoundManager>().CatPetPurr();
    }
}
