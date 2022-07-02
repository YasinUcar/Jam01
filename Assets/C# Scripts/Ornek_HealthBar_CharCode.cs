using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ornek_HealthBar_CharCode : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public Char_HealthBar_Script healthBarSc;


    void Start()
    {
        currentHealth = maxHealth;
        healthBarSc.SetMaxHealth(maxHealth);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBarSc.SetHealth(currentHealth);
    }
}
