using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : Enemy
{
    int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDamage(int x)
    {
        health += x;

        if (health <= 0)
        {
            Destroy(gameObject);

            SceneManager.LoadScene("MainMenu");
        }
    }
}
