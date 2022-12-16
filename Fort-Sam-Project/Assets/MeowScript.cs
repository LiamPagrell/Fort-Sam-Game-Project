using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeowScript : MonoBehaviour
{
    public SoundManager soundManager;
    // Start is called before the first frame update
    void Start()
    {

        Invoke(nameof(Delay), 0);
        Invoke(nameof(Delay), 0.5f);
        Invoke(nameof(Delay), 2);
    }

    // Update is called once per frame
    void Delay()
    {
        soundManager.Meow();
    }
}
