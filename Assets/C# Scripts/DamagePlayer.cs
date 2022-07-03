using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{

    public int playerHealth = 100;
    int damage = 10;
[SerializeField] GameObject hitParticle;

    void Start()
    {
        Debug.Log(playerHealth);
    }

    void Update()
    {
        var PlayerHBDeneme = GetComponent<PlayerHBDeneme>();
        PlayerHBDeneme.DeathOfCharacter();
    }

    public void OnTriggerEnter(Collider other)
    {
        var PlayerHBDeneme = GetComponent<PlayerHBDeneme>();
        if (other.tag == "EnemyDagger")
        {
            hitParticle.GetComponent<ParticleSystem>().Play();
            PlayerHBDeneme.TakeDamage(10);

        }
    }


}
