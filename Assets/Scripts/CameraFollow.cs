using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private float interpVelocity;
    [SerializeField] private float minDistance;
    [SerializeField] private float followDistance;
    [SerializeField] private Vector3 offset;

    private Vector3 TargetPos { get; set; }

    void FixedUpdate()
    {
        Vector3 posNoZ = transform.position;
        posNoZ.z = transform.position.z;

        Vector3 targetDirection = (transform.position - posNoZ);
        interpVelocity = targetDirection.magnitude * 5f;

        Camera.main.transform.position = Vector3.Lerp(transform.position, transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime) + offset, 0.25f);
    }
}
