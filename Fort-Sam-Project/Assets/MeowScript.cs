using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeowScript : MonoBehaviour
{
    public SoundManager soundManager;
    // Start is called before the first frame update
    void Start()
    {
        soundManager.Meow();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
