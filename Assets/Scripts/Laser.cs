using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float laserSpeed = 50;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * laserSpeed * Time.deltaTime;
    }
}
