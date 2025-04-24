using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject asteroidPrefab;
    public float spawnDelay = 3f;

    float timeToSpawn = 0f;

    void Update()
    {
        if (Time.time > timeToSpawn)
        {
            Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
            timeToSpawn = Time.time + spawnDelay;
        }
    }
}
