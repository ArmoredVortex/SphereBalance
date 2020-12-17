using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float speed;
    public Vector3 offset;
    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothenedPosition = Vector3.Lerp(transform.position, desiredPosition, speed);
        transform.position = smoothenedPosition;    
    }
}
