using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhoneCutSceneScript : MonoBehaviour
{
    public GameObject yellowPages;

    private float timer = 0f;

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;

        if (timer >= 3) {
            yellowPages.SetActive(false);
        }

        if (timer >= 7) {
            SceneManager.LoadScene("TutorialScene");
        }
    }
}
