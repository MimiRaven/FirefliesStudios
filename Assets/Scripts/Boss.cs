using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : Enemy
{
    public PauseMenu healthBar;
    int health = 100;
    public GameObject projectile;
    float nextShot;
    float fireRate;

    float shootCooldownTimer = 4f;
    bool shootCooldown;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        healthBar.SetBossHealth(health);
        nextShot = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Launch();

        if (shootCooldown) 
        {
            shootCooldownTimer -= Time.deltaTime;
            if (shootCooldownTimer < 0 )
            {
                shootCooldown = false;
                shootCooldownTimer = 4f;
            }
        }
    }

    void Launch()
    {
        if (shootCooldown == false)
        {
            anim.SetTrigger("Attack");
            Instantiate(projectile, transform.position, Quaternion.identity);
            shootCooldown = true;
        }
    }

    public void DealDamage(int x)
    {
        health += x;
        anim.SetTrigger("Hit");
        healthBar.SetBossHealth(health);

        if (health <= 0)
        {
            anim.SetBool("Dead", true);
            //Destroy(gameObject);

            Invoke("GameOver", 3f);
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("WinScreen");
    }    
}
