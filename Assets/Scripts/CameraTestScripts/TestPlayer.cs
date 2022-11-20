using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    AudioSource audioSource;

    public AudioClip jumpSound;
    public AudioClip shootSound;
    public AudioClip pickupSound;

    public GameObject lightingObj;
    public GameObject playerlight;
    public int lightLives = 3;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
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
            audioSource.clip = jumpSound;
            audioSource.Play();
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
                Lighting l = lightingObj.GetComponent<Lighting>();
                Light pl = playerlight.GetComponent<Light>();

                l.DecreaseLight();
                LivesChange(-1);
                p.direction = lookDirection;
                Instantiate(p, rigidbody.position + lookDirection * 2f, Quaternion.identity);
                shootCooldown = true;
                audioSource.clip = shootSound;
                audioSource.Play();

                if (pl.intensity > 0f)
                {
                    pl.intensity -= 0.1f;
                }
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
            Lighting l = lightingObj.GetComponent<Lighting>();
            Light pl = playerlight.GetComponent<Light>();

            if (lightLives < 10)
            {
                LivesChange(1);
                l.IncreaseLight();
                audioSource.clip = pickupSound;
                audioSource.Play();
                Destroy(x.gameObject);

                if (pl.intensity < 1.0f)
                {
                    pl.intensity += 0.1f;
                }
            }
        }

        if (x.CompareTag("Enemy"))
        {
            Lighting l = lightingObj.GetComponent<Lighting>();
            Light pl = playerlight.GetComponent<Light>();

            LivesChange(-1);
            l.DecreaseLight();

            if (pl.intensity >= 0.1f)
            {
                pl.intensity -= 0.1f;
            }
        }
    }

    void LivesChange(int x)
    {
        lightLives += x;

        if (lightLives <= 0)
        {
            SceneManager.LoadScene("MainMenu"); // Change to GameOver scene
        }
    }
}
