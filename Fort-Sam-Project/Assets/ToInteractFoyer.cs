using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToInteractFoyer : MonoBehaviour
{

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
