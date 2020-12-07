using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrackerScript : MonoBehaviour
{

    public static Scene sceneTracker;
    public static int sceneNumber;

    // Start is called before the first frame update
    void Start()
    {
        sceneTracker = SceneManager.GetActiveScene();

        sceneNumber = sceneTracker.buildIndex;

    }
}
