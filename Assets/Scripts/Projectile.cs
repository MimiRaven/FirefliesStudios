using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 direction;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    { 
        rb.AddForce(new Vector3 (direction.x, direction.y + 0.5f, direction.z) * 50f);

        Destroy(gameObject, 1f);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
    }
}
