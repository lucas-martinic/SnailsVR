using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveText : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        transform.Translate(0, Time.deltaTime*speed, 0);
    }
}
