using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsControllerScript : MonoBehaviour
{
    public void BackFunction() {
		SceneManager.LoadScene("MainMenuScene");
	}
}
