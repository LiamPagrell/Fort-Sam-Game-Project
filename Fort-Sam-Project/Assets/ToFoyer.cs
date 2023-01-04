using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToFoyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.parent.GetComponent<Animator>().enabled = false;
        Invoke(nameof(Load), 1f);

    }

    private void Load()
    {
        SceneManager.LoadScene("Hallen");

    }
}
