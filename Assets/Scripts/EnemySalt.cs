using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySalt : MonoBehaviour
{
    public float enemySpeed = 5;
    private EnemyPool pool;
    private Rigidbody rb;
    public int health = 10;
    public GameObject particleSystem;

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
        GameObject obj = Instantiate(particleSystem, transform.position, Quaternion.identity);
        Destroy(obj, 3);
        ResetPos();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Laser"))
        {
            health--;
            if(health <= 0)
            {
                Die();
            }
        }
    }

    void ResetPos()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        rb.isKinematic = true;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = new Vector3(250, 8, Random.Range(-4, 4));
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        rb.isKinematic = false;
    }
}
