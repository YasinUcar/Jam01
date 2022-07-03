using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DamagePlayer : MonoBehaviour
{

    public AudioSource attackSound;
    public AudioClip goblinClip;
    int damage = 10;
    [SerializeField] GameObject hitParticle;

    void Start()
    {

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


            Instantiate(hitParticle, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), transform.rotation);
            if (attackSound.isPlaying != true)
            {
                attackSound.PlayOneShot(goblinClip);
            }
            hitParticle.GetComponent<ParticleSystem>().Play();
            PlayerHBDeneme.TakeDamage(3);

        }
        if (other.tag == "yeniSahne")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }


}
