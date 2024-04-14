using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserMovenet : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 240.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Здесь же вызывается анимация персонажа

        Vector3 movement = new Vector3(horizontal, 0, vertical) * speed;
        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
    }
}
