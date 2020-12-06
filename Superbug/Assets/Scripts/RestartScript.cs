using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{

    // Update is called once per frame
    public void restartFunction()
    {
        SceneManager.LoadScene("MainGameScene");
    }
}
