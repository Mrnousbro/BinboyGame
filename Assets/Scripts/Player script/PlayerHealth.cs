using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;
    public HealthBar healthBar;
    private Vector3 startPoint;

    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.position;
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);       
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            gameObject.transform.position = startPoint;
            healthBar.SetHealth(maxHealth);
            health = maxHealth;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            TakeDamage(2);
            healthBar.SetHealth(health);
        }

        else if (collision.gameObject.tag == "WalkingEnemy")
        {
            TakeDamage(3);
            healthBar.SetHealth(health);
        }

        else if (collision.gameObject.tag == "FallDetector")
        {
            TakeDamage(1);
            healthBar.SetHealth(health);
        }
    }
}

