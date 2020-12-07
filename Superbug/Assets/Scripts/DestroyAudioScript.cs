using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAudioScript : MonoBehaviour
{
    public string music;

    void Start() {

        Destroy(GameObject.Find(music));

    }
}
