using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Health_Bar : MonoBehaviour
{
    public float currenthealth;
    public float maxHealth;

    public GameObject healthBarUI;
    public Slider slide;

    void Start()
    {

        currenthealth = maxHealth;
        slide.value = CalculateHealth();
    }

    void Update()
    {
        slide.value = CalculateHealth();

        if (currenthealth < maxHealth)
        {
            healthBarUI.SetActive(true);
        }

        if(currenthealth <= 0)
        {
            Destroy(gameObject);
        }

        if(currenthealth > maxHealth)
        {
            currenthealth = maxHealth;
        }
    }

    float CalculateHealth()
    {
        var enemytriggersc = GetComponent<EnemyTriggerScript>();
        enemytriggersc.PlayerDamage(10);
        return currenthealth - enemytriggersc.playerDamage;
    }
}
