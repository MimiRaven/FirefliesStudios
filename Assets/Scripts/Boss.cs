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
        healthBar.SetBossHealth(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDamage(int x)
    {
        health += x;

        healthBar.SetBossHealth(x);

        if (health <= 0)
        {
            Destroy(gameObject);

            SceneManager.LoadScene("WinScreen");
        }
    }
}
