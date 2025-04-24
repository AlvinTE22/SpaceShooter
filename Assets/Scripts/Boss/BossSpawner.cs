using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{

    public GameObject bossPrefab;
    public float spawnDelay = 30f;

    float timeToSpawn = 0f;

    void Update()
    {
        if (Time.time > timeToSpawn && Time.time !< 30f)
        {
            Instantiate(bossPrefab, transform.position, Quaternion.identity);
            timeToSpawn = Time.time + spawnDelay;
        }
    }
}
