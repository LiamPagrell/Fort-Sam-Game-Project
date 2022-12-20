using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatChase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("BigWhiskers").GetComponent<Animator>().SetTrigger("RatAnim");
        Camera.main.GetComponent<CameraFollow>().TemporaryFollow(transform, 3);
    }


}
