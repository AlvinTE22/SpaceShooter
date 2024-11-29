using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject asteroidPrefab;
    public float spawnDelay = 3f;

    float timeToSpawn = 0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToSpawn)
        {
            Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
            timeToSpawn = Time.time + spawnDelay;
        }
    }
}
