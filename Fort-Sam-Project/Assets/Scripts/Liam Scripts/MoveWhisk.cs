using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWhisk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("MrWhiskers").GetComponent<Animator>().SetTrigger("MoveWhisk");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
