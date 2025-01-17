using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] float fireRate = 2f;
    [SerializeField] GameObject enemyProjectilePrefab;

    float timeToShoot = 0f;
    void Start()
    {
        timeToShoot = Time.time + fireRate;
    }

    void Update()
    {
        if (Time.time > timeToShoot)
        {
            Instantiate(enemyProjectilePrefab, transform.position, Quaternion.identity);
            timeToShoot = Time.time + fireRate;
        }
    }
}
