using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonPush : MonoBehaviour
{
    void OnTriggerEnter(Collider collider) {
        SceneManager.LoadScene("Main");
    }
}
