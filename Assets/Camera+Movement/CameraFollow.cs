using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public Vector3 offset = new Vector3(0f, 5f, -10f);
    public float rotationSpeed = 5.0f;
    public float minAngle = -30f;
    public float maxAngle = 60f;

    private float horizontalAngle = 0f;
    private float verticalAngle = 0f;

    void Start()
    {

    }


    void Update()
    {

        if (target != null)
        {
            horizontalAngle += Input.GetAxis("Mouse X") * rotationSpeed;
            verticalAngle -= Input.GetAxis("Mouse Y") * rotationSpeed;
            verticalAngle = Mathf.Clamp(verticalAngle, minAngle, maxAngle); 

            
            Quaternion rotation = Quaternion.Euler(verticalAngle, horizontalAngle, 0);


            transform.position = target.position + rotation * offset;
            transform.LookAt(target);
        }

    }
}
