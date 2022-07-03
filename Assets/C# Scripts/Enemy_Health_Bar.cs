using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Health_Bar : MonoBehaviour
{
    public float currenthealth;
    float maxHealth = 1;

    public GameObject healthBarUI;
    public Slider slide;

    void Start()
    {

        currenthealth = maxHealth;
        slide.value = maxHealth;
    }

    void Update()
    {

        slide.value = currenthealth;
        if (currenthealth < maxHealth)
        {
            healthBarUI.SetActive(true);
        }

        if (currenthealth <= 0)
        {
            Destroy(gameObject);
        }

        if (currenthealth > maxHealth)
        {
            currenthealth = maxHealth;
        }

    }

    float CalculateHealth()
    {

        return currenthealth - maxHealth;
    }
    public void lastDamage()
    {
        var EnemyTriggerScript = GetComponent<EnemyTriggerScript>();
        float gelenDeger = EnemyTriggerScript.playerDamage;
        currenthealth -= gelenDeger;
    }

}
