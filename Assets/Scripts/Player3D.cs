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
    //private jumpforce Jump;
    private Rigidbody rb;
    public float speed = 7;
    bool enableMove = true;
    Vector3 lookDirection = Vector3.forward;

    //Player3DControl controls;

    // Projectile
    public GameObject projectileObject;

    void Awake()
    {
        //controls = new Player3DControl();
        //controls.Enable();
       playerInput = GetComponent<PlayerInput>();
       rb = GetComponent<Rigidbody>();

        //controls.Land.Move.performed += ctx =>
        //{
        //    direction = ctx.ReadValue<float>();
        //};
        //
        //controls.Land.JumpAction.performed += ctx => Jump();
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

    void OnJump()
    {
        Debug.Log("Jumped");
        //Jump = 5f;
    }
}
