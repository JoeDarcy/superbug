﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartControllerScript : MonoBehaviour
{
	public void StartFunction() {
		SceneManager.LoadScene("Level_1_Scene");
	}
}
