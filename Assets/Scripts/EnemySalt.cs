using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySalt : MonoBehaviour
{
    public float enemySpeed = 5;
    private EnemyPool pool;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        pool = GetComponentInParent<EnemyPool>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += enemySpeed * -Vector3.right * Time.deltaTime;
        if (transform.position.x <= -50)
        {
            ResetPos();
        }
    }

    public void Die()
    {
        ResetPos();
    }

    void ResetPos()
    {
        gameObject.SetActive(false);
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = new Vector3(250, 8, Random.Range(-4, 4));
        gameObject.SetActive(true);
    }
}
