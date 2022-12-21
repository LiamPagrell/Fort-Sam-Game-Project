using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeCameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.GetComponent<CameraFollow>().TemporaryFollow(transform, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
