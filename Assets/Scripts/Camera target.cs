using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameratarget : MonoBehaviour
{
    public GameObject CameraTarget;
    public float cameraSpeed = 0.02f;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, CameraTarget.transform.position, cameraSpeed);
    }
}
