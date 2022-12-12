using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobEyesLock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Robot_Eyes").GetComponent<Animator>().SetTrigger("RoboLock");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
