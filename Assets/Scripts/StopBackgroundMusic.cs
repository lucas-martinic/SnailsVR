using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBackgroundMusic : MonoBehaviour
{
    void Start()
    {
        Destroy(GameObject.Find("BackgroundMusic"));
    }
}
