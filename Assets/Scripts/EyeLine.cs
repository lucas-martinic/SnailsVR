using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeLine : MonoBehaviour
{
    public Transform target;
    LineRenderer lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, transform.position);
    }

    private void Update()
    {
        lineRenderer.SetPosition(1, target.transform.position);
    }
}
