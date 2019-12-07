using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float time;
    private float timeBetweenEnemys = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= timeBetweenEnemys)
        {
            Instantiate(enemyPrefab, new Vector3(250, 8, Random.Range(-4, 4)), Quaternion.identity);
            time = 0;
            if (timeBetweenEnemys < 0.5) return;
            timeBetweenEnemys -= 0.1f;
        }
    }
}
