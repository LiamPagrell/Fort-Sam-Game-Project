using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatRun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Cat").GetComponent<Animator>().SetTrigger("CatAnim");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
