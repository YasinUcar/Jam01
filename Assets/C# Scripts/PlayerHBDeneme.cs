using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHBDeneme : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public CanvasHealthBarCode HealthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        HealthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        HealthBar.SetHealth(currentHealth);
    }

    public void DeathOfCharacter()
    {
        if (currentHealth == 0)
        {
            Debug.Log("Öldün");
        }
    }
}
