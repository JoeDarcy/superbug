using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfectionSliderScript : MonoBehaviour
{
	public GameObject bulletInfection;

	public Slider sliderInstance;

	private int infectionTotal;

	public static bool playerIsDead = false;

	private int currentScene;

	private void Start() {
		// Zero slider on start
		infectionTotal = 0;

		currentScene = SceneTrackerScript.sceneNumber;
	}


	private void Update() {

		NextSceneFunction();

		infectionTotal = BulletDamageScript.infection;

		sliderInstance.value = infectionTotal;
	}

	public void OnValueChanged(float value) {
		Debug.Log("New value: " + value);
	}

	public void NextSceneFunction() {
		if (infectionTotal >= 100 && currentScene == 5) {

 			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		else if (infectionTotal >= 200 && currentScene == 7) {

			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		else if (infectionTotal >= 300 && currentScene == 9) {

			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
	
}
