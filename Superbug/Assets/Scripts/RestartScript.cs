using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
	public static int originSceneNumber;

	private void Update() {

		originSceneNumber = SceneTrackerScript.sceneNumber;
	}

	// Update is called once per frame
	public void restartFunction()
    {
		SceneManager.LoadScene(originSceneNumber);
	}
}
