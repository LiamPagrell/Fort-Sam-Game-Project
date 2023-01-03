using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLivingRoom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.parent.GetComponent<Animator>().enabled = false;
        Invoke(nameof(Load), 0.1f);
    }

    private void Load()
    {
        SceneManager.LoadScene("Vardagsrummet");

    }
}
