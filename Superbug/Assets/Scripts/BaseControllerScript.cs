using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseControllerScript : MonoBehaviour
{
    public GameObject baseExternal;

    private float timer = 0f;

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;

        if (timer >= 3) {
            baseExternal.SetActive(false);
        }

        if (timer >= 11) {
            SceneManager.LoadScene("Level_3_Scene");
        }
    }
}
