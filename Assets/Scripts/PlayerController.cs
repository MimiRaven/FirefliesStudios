using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Vector2 movement;
    private Rigidbody rb;
    public int speed = 5;

    private PlayerInput playerInput;
    private InputAction JumpAction;

    bool enableMove = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
        JumpAction = playerInput.actions["Jump"];
    }

        // Start is called before the first frame update
        void Start()
        {

        }

    private void OnMovement(InputValue value) // These are Movement Keys
    {
        if (enableMove == true)
        {
            movement = value.Get<Vector2>();
        }
    }

    void FixedUpdate()
    {
        if (enableMove == true && movement.x != 0 || movement.y != 0)
        {
            rb.velocity = movement * speed;
        }
    }
}
