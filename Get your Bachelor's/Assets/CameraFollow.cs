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

    void Start()
    {
        Vector3 targetPosition = new Vector3(
            target.position.x,
            target.position.y,
            transform.position.z
        );
        transform.position = targetPosition;
    }

    void FixedUpdate()
    {
        Vector3 targetPosition = new Vector3(
                target.position.x,
                target.position.y,
                transform.position.z
            );
        targetPosition.x = Mathf.Clamp(targetPosition.x, minPos.x, maxPos.x);
        targetPosition.y = Mathf.Clamp(targetPosition.y, minPos.y, maxPos.y);
                    
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
    }
}