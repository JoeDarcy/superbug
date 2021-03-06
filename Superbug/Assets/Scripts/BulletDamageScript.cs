﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletDamageScript : MonoBehaviour
{
    public GameObject enemy;


    private float enemyHealth = 100.0f;

    // Infection static variables
    public static int infection = 0;
    private static int infectionRate = 1;

  

	private void Start() {
        // Zero infection total 
        //infection = 0;
    }

	// Update is called once per frame
	void Update() {   

        if (enemyHealth <= 0) {
            GameObject.Destroy(enemy);
        }
    }

	private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Enemy") {               
            // Don't forget ^ this bit. Gets the emeny gameObject

                // Genius level code! https://www.youtube.com/watch?v=LMOGPN5p4NU&ab_channel=AlexanderZotov
                Destroy(collision.gameObject);
                Destroy(gameObject);


            infection += infectionRate;        

        }       
	}
}
