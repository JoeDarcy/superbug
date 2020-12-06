using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthScript : MonoBehaviour
{
    public GameObject health_3;
    public GameObject health_2;
    public GameObject health_1;


    public static int playerHealth = 3;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update() {

        timer += Time.deltaTime;

        if (playerHealth == 2) {
            GameObject.Destroy(health_3);
        } else if (playerHealth == 1) {
            GameObject.Destroy(health_2 );
        } else if (playerHealth == 0) {
            GameObject.Destroy(health_1);

            // Change scene on death
            if (timer > 5) {
                SceneManager.LoadScene(6);
            }
            
        }
    }

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Enemy" && timer > 2) {

            playerHealth -= 1;
            Debug.Log("Player takes damage!!!!!");
            Debug.Log(playerHealth);
            timer = 0;
        }
	}

    
}
