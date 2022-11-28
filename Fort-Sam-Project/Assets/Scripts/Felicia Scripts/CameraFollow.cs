using UnityEngine;
public class CameraFollow : MonoBehaviour
{

    public Transform Sam;
    [SerializeField] Vector2 minPositions, maxPositions;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(Sam.position.x, minPositions.x, maxPositions.x), Mathf.Clamp(Sam.position.y, minPositions.y, maxPositions.y), transform.position.z); //Sam.transform.position + new Vector3(0, 1, -5);
    }

    void Awake()
    {

    }
}

