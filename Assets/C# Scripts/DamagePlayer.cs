using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{

    public int playerHealth = 30;
    int damage = 10;
    

    void Start()
    {
        Debug.Log(playerHealth); 
    }

    void Update()
    {
        var HealthChange = GetComponent<PlayerHBDeneme>();
        HealthChange.DeathOfCharacter();
    }

    public void OnTriggerEnter(Collider other)
    {
        var HealthChange = GetComponent<PlayerHBDeneme>();
        if (other.tag == "EnemyDagger")
        {
            HealthChange.TakeDamage(10);
        }
    }


}
