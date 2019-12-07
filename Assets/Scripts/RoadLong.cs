﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadLong : MonoBehaviour
{
    public float roadSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += roadSpeed * -Vector3.forward * Time.deltaTime;
    }
}
