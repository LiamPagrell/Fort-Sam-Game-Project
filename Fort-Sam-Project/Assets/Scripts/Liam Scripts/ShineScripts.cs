using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShineScripts : MonoBehaviour
{
    public GameObject Shiny;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseOver()
    {
        Shiny.gameObject.GetComponent<Animator>().SetTrigger("StartShine");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
