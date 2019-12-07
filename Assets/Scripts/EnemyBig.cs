using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBig : MonoBehaviour
{
    private float counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if(counter >= 50)
        {
            GetComponent<MeshRenderer>().enabled = true;
            GetComponent<EnemySalt>().enabled = true;
            GetComponent<BoxCollider>().enabled = true;
            this.enabled = false;
        }
    }
}
