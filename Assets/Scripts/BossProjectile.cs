using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;

public class BossProjectile : MonoBehaviour
{
    float moveSpeed = 10f;
    Rigidbody rb2d;
    GameObject player;
    Vector2 direction;

    void Awake()
    {

    }

    void Start()
    {
        rb2d = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");
        direction = (player.transform.position - transform.position).normalized * moveSpeed;
        rb2d.velocity = new Vector3(direction.x, direction.y);
        Destroy(gameObject, 3f);
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            TestPlayer p = other.collider.GetComponent<TestPlayer>();
            
            p.LivesChange(-1);
            Destroy(gameObject);
        }

    }
}
