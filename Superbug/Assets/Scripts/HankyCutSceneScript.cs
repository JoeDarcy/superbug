using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HankyCutSceneScript : MonoBehaviour
{
    public GameObject achoo;
    public GameObject eyesOpen;
    public GameObject hanky;

    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2) {
            achoo.SetActive(false);            
        }

        if (timer >= 3) {           
            eyesOpen.SetActive(false);
		}

        if (timer >= 6) {
            SceneManager.LoadScene("PhoneScene");
		}
    }
}
