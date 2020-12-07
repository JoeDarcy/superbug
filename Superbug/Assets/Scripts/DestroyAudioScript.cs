using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAudioScript : MonoBehaviour
{
    private static bool resetAudioController;

    public string music;

    void Start() {

        AudioControllerScript.created = false;

        Destroy(GameObject.Find(music));

    }
}
