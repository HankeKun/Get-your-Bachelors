using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
    //let camera follow target
public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothing;

    public Vector2 maxPos;
    public Vector2 minPos;

    private void Start()
    {
        transform.position = GetClampedCameraPosition();
    }

    private void FixedUpdate()
    {
        if (transform.position != target.position)
        {
            transform.position = Vector3.Lerp(transform.position, GetClampedCameraPosition(), smoothing);
        }
    }

    private Vector3 GetClampedCameraPosition()
    {
        Vector3 targetPosition = new Vector3(
                target.position.x,
                target.position.y,
                transform.position.z
            );

        targetPosition.x = Mathf.Clamp(targetPosition.x, minPos.x, maxPos.x);
        targetPosition.y = Mathf.Clamp(targetPosition.y, minPos.y, maxPos.y);

        return targetPosition;
    }
}