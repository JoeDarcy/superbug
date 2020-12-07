using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioControllerScript : MonoBehaviour {

	public string sceneToKillMusic;
	public static bool created = false;

	private void Start() {

		CheckSceneToKill();

		if (!created) {
			DontDestroyOnLoad(this.gameObject);

			created = true;
		}
		
		else {
			
			Destroy(this.gameObject);
		}			
	}

	private void CheckSceneToKill() {
		
		Scene currentScene = SceneManager.GetActiveScene();

		string sceneName = currentScene.name;

		if (sceneName == sceneToKillMusic) {
			GameObject.Destroy(this);
		}
		
	}








}
    

