using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfectionSliderScript : MonoBehaviour
{
	public GameObject bulletInfection;

	public Slider sliderInstance;

	private static int infectionTotal;

	private void Start() {
		// Zero slider on start
		sliderInstance.value = 0;	
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
		if (infectionTotal >= 100) {
 			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
	
}
