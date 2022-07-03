using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{

    public int playerHealth = 100;
    int damage = 10;


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
           PlayerHBDeneme.TakeDamage(10);
            Debug.Log(PlayerHBDeneme.currentHealth);
        }
    }


}
