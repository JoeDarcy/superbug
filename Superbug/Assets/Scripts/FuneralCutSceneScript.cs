using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FuneralCutSceneScript : MonoBehaviour
{
    public GameObject church;
    public GameObject deathCloseup;
    public GameObject canvas;

    private float timer = 0f;

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;

        if (timer >= 4) {
            church.SetActive(false);
        }

        if (timer >= 8) {
            deathCloseup.SetActive(false);
        }

        if (timer >= 12) {
            canvas.SetActive(true);
        }

        if (timer >= 20) {
            Application.Quit();
        }
    }
}
