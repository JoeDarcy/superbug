using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PharmacyCutSceneScript : MonoBehaviour
{
    public GameObject external;
    public GameObject host;

    private float timer = 0f;

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;

        if (timer >= 3) {
            external.SetActive(false);
        }

        if (timer >= 3) {
            
        }

        if (timer >= 9) {
            SceneManager.LoadScene("Level_2_Scene");
        }
    }
}
