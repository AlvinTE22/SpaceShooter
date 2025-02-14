using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject playerProjectilePrefab;
    public float fireDelay = 0.5f;
    float timeToShoot = 0f;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKey(KeyCode.Space))
        {
            if (Time.time > timeToShoot)
            {
                Instantiate(playerProjectilePrefab, transform.position, Quaternion.identity);
                timeToShoot = Time.time + fireDelay;
            }
        }
    }
}
