using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfectionSliderScript : MonoBehaviour
{
	public GameObject bulletInfection;

	public Slider sliderInstance;

	private static int infectionTotal;

	private void Start() {
		/*
		sliderInstance.minValue = 0;
		sliderInstance.maxValue = 100;
		sliderInstance.wholeNumbers = true;
		sliderInstance.value = 50;
		*/
	}


	private void Update() {

		infectionTotal = BulletDamageScript.infection;

		sliderInstance.value = infectionTotal;
	}

	public void OnValueChanged(float value) {
		Debug.Log("New value: " + value);
	}
}
