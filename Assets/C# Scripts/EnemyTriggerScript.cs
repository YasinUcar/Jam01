using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriggerScript : MonoBehaviour
{
    public float playerDamage;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerDamage(0.100f);
            var enemyhealthbar = GetComponent<Enemy_Health_Bar>();
            enemyhealthbar.lastDamage();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "OurWeapon")
        {
            var enemyhealthbar = GetComponent<Enemy_Health_Bar>();

        }
    }
    public void PlayerDamage(float damagePlayer)
    {
       playerDamage= damagePlayer;
        var enemyhealthbar = GetComponent<Enemy_Health_Bar>();
       
    }

}
