using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitToLivingFromFoyer : MonoBehaviour
{
    public GameObject TransitionSam;
    public GameObject Characters;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Invoke(nameof(Load), 0.5f);
        }
        //Characters.GetComponent<Animator>().SetTrigger("TransitLiving");
        //TransitionSam.GetComponent<Animator>().SetTrigger("TransitionAlive");
    }
    
    
private void Load()
    {
        SceneManager.LoadScene("Vardagsrummet");

    }
}
