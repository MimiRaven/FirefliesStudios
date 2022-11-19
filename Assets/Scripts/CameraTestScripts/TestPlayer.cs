using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    public float runSpeed;

    Rigidbody rigidbody;
    Vector3 lookDirection = Vector3.left;

    bool grounded = false;
    Collider[] groundCollisions;
    float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float jumpHeight;

    public GameObject projectileObject;
    public float shootCooldownTimer = 2;
    public bool shootCooldown;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shootCooldown)
        {
            shootCooldownTimer -= Time.deltaTime;
            if (shootCooldownTimer <= 0 )
            {
                shootCooldownTimer = 2;
                shootCooldown = false;
            }
        }
    }

    void FixedUpdate()
    {
        if (grounded && Input.GetAxis("Jump") > 0)
        {
            grounded = false;
            rigidbody.AddForce(new Vector3(0, jumpHeight, 0));
        }

        groundCollisions = Physics.OverlapSphere(groundCheck.position, groundCheckRadius, groundLayer);
        if (groundCollisions.Length > 0) grounded = true;
        else grounded = false;

        float move = Input.GetAxis("Horizontal");

        rigidbody.velocity = new Vector3(move * runSpeed, rigidbody.velocity.y, 0);

        lookDirection.x = move;

        if (shootCooldown == false && Input.GetAxis("Fire1") > 0)
        {
            if (lookDirection.x > 0 || lookDirection.x < 0)
            {
                Projectile p = projectileObject.GetComponent<Projectile>();
                p.direction = lookDirection;
                Instantiate(p, rigidbody.position + lookDirection * 2f, Quaternion.identity);
                shootCooldown = true;
            }
        }
    }

    void OnTriggerEnter(Collider x)
    {
        switch (x.tag)
        {
            case "RotateLeft1":
                FindObjectOfType<Turntable>().RotateLeft1();
                break;
            case "RotateLeft2":
                FindObjectOfType<Turntable>().RotateLeft2();
                break;
            case "RotateLeft3":
                FindObjectOfType<Turntable>().RotateLeft3();
                break;
            case "RotateLeft4":
                FindObjectOfType<Turntable>().RotateLeft4();
                break;
            case "RotateRight1":
                FindObjectOfType<Turntable>().RotateRight1();
                break;
            case "RotateRight2":
                FindObjectOfType<Turntable>().RotateRight2();
                break;
            case "RotateRight3":
                FindObjectOfType<Turntable>().RotateRight3();
                break;
            case "RotateRight4":
                FindObjectOfType<Turntable>().RotateRight4();
                break;
        }

        if (x.CompareTag("Collectible"))
        {
            Destroy(x.gameObject);
        }
    }
}
