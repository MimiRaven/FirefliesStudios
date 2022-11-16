using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Player3D : MonoBehaviour
{
    // Movement
    private Vector3 movement;
    private PlayerInput playerInput;
    private Rigidbody rb;
    public float speed = 7;
    bool enableMove = true;
    Vector3 lookDirection = Vector3.forward;

    // Projectile
    public GameObject projectileObject;

    void Awake()
    {
       playerInput = GetComponent<PlayerInput>();
       rb = GetComponent<Rigidbody>();
    }

    void OnMovement(InputValue value)
    {
        if (enableMove)
        {
            movement = value.Get<Vector3>();
        }
    }

    void OnShooting()
    {
        Projectile p = projectileObject.GetComponent<Projectile>();

        Instantiate(p, rb.position + lookDirection * 0.5f, Quaternion.identity);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
