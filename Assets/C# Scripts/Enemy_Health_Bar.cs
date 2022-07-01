using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Health_Bar : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public GameObject healthBarUI;
    public Slider slide;

    private void Start()
    {

        health = maxHealth;
        slide.value = CalculateHealth();
    }

    private void Update()
    {
        slide.value = CalculateHealth();

        if (health < maxHealth)
        {
            healthBarUI.SetActive(true);
        }

        if(health <= 0)
        {
            Destroy(gameObject);
        }

        if(health > maxHealth)
        {
            health = maxHealth;
        }
    }

    float CalculateHealth()
    {
        return health / maxHealth;
    }
}
