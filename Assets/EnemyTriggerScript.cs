using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriggerScript : MonoBehaviour
{
    public int playerDamage = 10;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerDamage(10);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "OurWeapon")
        {
            var enemyhealthbar = GetComponent<Enemy_Health_Bar>();

        }
    }
    public void PlayerDamage(int damageplayer)
    {
        var enemyhealthbar = GetComponent<Enemy_Health_Bar>();
       
    }

}
