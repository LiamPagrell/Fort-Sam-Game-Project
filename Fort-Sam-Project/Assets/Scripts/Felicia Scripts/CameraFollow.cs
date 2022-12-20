using UnityEngine;
public class CameraFollow : MonoBehaviour
{

    public Transform Sam;
    [SerializeField] Vector2 minPositions, maxPositions;

    Transform currentTarget;

    private void Start()
    {
        currentTarget = Sam;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = new Vector3(Mathf.Clamp(currentTarget.position.x, minPositions.x, maxPositions.x), Mathf.Clamp(currentTarget.position.y, minPositions.y, maxPositions.y), transform.position.z);

        Vector3 diff = transform.position - targetPos;

        transform.position -= diff * 0.1f; //Sam.transform.position + new Vector3(0, 1, -5);
    }

    public void TemporaryFollow(Transform target, float time)
    {
        currentTarget = target;
        Invoke(nameof(ResetCameraTarget), time);
    }

    void ResetCameraTarget()
    {
        currentTarget = Sam;
    }
}

