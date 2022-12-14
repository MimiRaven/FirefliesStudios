using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 direction;
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        GameObject p = GameObject.FindWithTag("Player");
        TestPlayer tp = p.GetComponent<TestPlayer>();

        switch(tp.looking)
        {
            case TestPlayer.lookDir.right:
                rb.AddForce(new Vector3(50, direction.y + 1f, direction.z) * 10f);
                anim.SetFloat("Blend", 1);
                break;
            case TestPlayer.lookDir.left:
                rb.AddForce(new Vector3(-50, direction.y + 1f, direction.z) * 10f);
                anim.SetFloat("Blend", -1);
                break;

        }

        Destroy(gameObject, 1f);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Enemy e = collision.gameObject.GetComponent<Enemy>();
            e.Die();
        }

        if (collision.gameObject.CompareTag("Boss"))
        {
            Boss b = collision.gameObject.GetComponent<Boss>();

            b.DealDamage(-25);
            Destroy(gameObject);
        }
    }
}
