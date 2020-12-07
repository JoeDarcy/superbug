using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TempMainMenuScript : MonoBehaviour
{
    public void PlayButton() {
		SceneManager.LoadScene("HankyCutScene");
	}

	public void OptionsButton() {
		SceneManager.LoadScene("OptionsMenuScene");
	}

	public void QuitButton() {
		Application.Quit();
	}
}
