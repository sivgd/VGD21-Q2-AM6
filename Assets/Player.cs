using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public Transform Spawnpoint;
    public GameObject Gouba;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if(currentHealth < 0)
        {
            Gouba.transform.position = Spawnpoint.position;

            currentHealth = maxHealth;
            healthBar.SetHealth(currentHealth);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "ICE")
        {
            TakeDamage(1);
        }
    }
}
