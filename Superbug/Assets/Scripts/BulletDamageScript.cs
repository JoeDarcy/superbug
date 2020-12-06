using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamageScript : MonoBehaviour
{
    public GameObject enemy;

    private float enemyHealth = 100.0f;
    private float bulletDamage = 25.0f;

    private static float infection = 0;
    private static float infectionRate = 10;

    private bool enemyIsDead = false;

    private static void infectionSlider(float infection, float infectionRate) {

        infection += infectionRate * 10;
    }

    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0) {
            GameObject.Destroy(enemy);
        }
    }

	private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Enemy") {               
            // Don't forget ^ this bit. Gets the emeny gameObject

            Debug.Log("Bullet damage triggered");

            //enemyHealth -= bulletDamage;

            Debug.Log(enemyHealth);

            

            Debug.Log("Enemy is dead");

                // Genius level code! https://www.youtube.com/watch?v=LMOGPN5p4NU&ab_channel=AlexanderZotov
                Destroy(collision.gameObject);
                Destroy(gameObject);


            // Increment the infection rate 
            infectionSlider(infection, infectionRate);

            infection += infectionRate;


            Debug.Log("Infection = " + infection + "%");
            

        }       
	}

    
}
