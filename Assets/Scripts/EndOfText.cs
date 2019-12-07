using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfText : MonoBehaviour
{
    void OnTriggerEnter(Collider collider) {
        SceneManager.LoadScene("Natasha");
    }
}
