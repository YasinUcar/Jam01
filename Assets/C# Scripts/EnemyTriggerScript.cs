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
       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerDamage(0.100f);
            var enemyhealthbar = GetComponent<Enemy_Health_Bar>();
            enemyhealthbar.lastDamage();
        }*/
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "OurWeapon")
        {
            PlayerDamage(0.200f);
            var enemyhealthbar = GetComponent<Enemy_Health_Bar>();
            enemyhealthbar.lastDamage();
        }
        if (other.gameObject.tag =="OurWeapon2")
        {
            PlayerDamage(0.300f);
            var enemyhealthbar = GetComponent<Enemy_Health_Bar>();
            enemyhealthbar.lastDamage();
        }

    }
    public void PlayerDamage(float damagePlayer)
    {
        playerDamage = damagePlayer;
        //var enemyhealthbar = GetComponent<Enemy_Health_Bar>();

    }

}
