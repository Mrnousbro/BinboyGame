using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    // TENHLE SCRIPT SE NEPOUŽÍVÁ

    public PlayerHealth playerHealth;
    public int damage = 2;
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //Debug.Log("HP Před: " + playerHealth.health);
            playerHealth.TakeDamage(2);
            //Debug.Log("HP Po: " + playerHealth.health);
        }
    }
}
