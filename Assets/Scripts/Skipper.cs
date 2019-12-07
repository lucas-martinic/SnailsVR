using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skipper : MonoBehaviour
{
    public string nextScene;

    void Update()
    {
        if (Input.GetKey("space")) {
            Debug.Log("spaaaaaace");
            SceneManager.LoadScene(nextScene);
        }
    }
}
