using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // The target to follow (your player).
    public float smoothSpeed = 0.125f;  // Adjust this to control the smoothness of the follow.

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired position and smoothly move towards it.
            Vector3 desiredPosition = target.position;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // Look at the target.
            transform.LookAt(target);
        }
    }
}

