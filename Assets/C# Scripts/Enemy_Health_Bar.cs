using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Health_Bar : MonoBehaviour
{
    [SerializeField] GameObject hitParticle;
    public float currenthealth;
    float maxHealth = 1;
    Animator anim;
    public GameObject healthBarUI;
    public Slider slide;
    public GameObject goblin;
    private bool olduMu = false;
    void Start()
    {

        currenthealth = maxHealth;
        slide.value = maxHealth;
        olduMu = true;
        anim = GetComponent<Animator>();
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
            hitParticle.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            hitParticle.GetComponent<ParticleSystem>().Play();
            Destroy(goblin.gameObject);

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
