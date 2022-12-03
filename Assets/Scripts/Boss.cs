using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : Enemy
{
    public PauseMenu healthBar;
    int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        healthBar.SetBossHealth(health);
    }

    // Update is called once per frame
    void Update()
    {
        
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
