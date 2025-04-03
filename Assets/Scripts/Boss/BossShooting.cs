using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShooting : MonoBehaviour
{

    [SerializeField] float fireRate = 2f;
    [SerializeField] GameObject bossBackLeftProjectilePrefab;

    float timeToShoot = 0f;

    void Start()
    {
        timeToShoot = Time.time + fireRate;
    }

    void Update()
    {
        if (Time.time > timeToShoot)
        {
            Instantiate(bossBackLeftProjectilePrefab, transform.position, Quaternion.identity);
            timeToShoot = Time.time + fireRate;
        }
    }
}
