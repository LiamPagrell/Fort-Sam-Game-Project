using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraEvent : MonoBehaviour
{
    public Transform cat;
    [SerializeField] Vector2 minPositions, maxPositions;
    public Animator animator;
   

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        bool thisCameraActive = GetComponent<CameraFollow>().enabled;
        if (thisCameraActive)
        {
        cat.gameObject.GetComponent<Animator>().SetTrigger("Running");
        transform.position = new Vector3(Mathf.Clamp(cat.position.x, minPositions.x, maxPositions.x), Mathf.Clamp(cat.position.y, minPositions.y, maxPositions.y), transform.position.z);
        GetComponent<CameraFollow>().enabled = false;
           
        }
    }
   


}
