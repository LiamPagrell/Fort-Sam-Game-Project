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

    private void OnMouseOver() ///Eller Mouse Over
    {
        Shiny.gameObject.GetComponent<Animator>().SetTrigger("StartShine");
        StartCoroutine(Wait());
    }

    private void OnMouseExit()
    {
        Shiny.gameObject.GetComponent<Animator>().SetTrigger("StopShine");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.3f);
        Shiny.gameObject.GetComponent<Animator>().ResetTrigger("StartShine");
    }
}
