using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    [Header("Camera")]
    public Transform targetObject;
    public float smoothSpeed = 10f;
    public Vector3 cameraOffset;


    private void Start()
    {


    }


    void LateUpdate()
    {

        Vector3 desiredCameraPosition = targetObject.position + cameraOffset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredCameraPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;


        transform.LookAt(targetObject);

    }


}
