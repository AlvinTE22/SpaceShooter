using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3f;
    public float fireDelay = 3f;
    public GameObject enemyProjectilePrefab;

    Rigidbody2D rigidBody;
    float timeToShoot = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector3(0, -speed, 0);
    }

    private void Update()
    {
        if (Time.time > timeToShoot)
        {
            Instantiate(enemyProjectilePrefab, transform.position, Quaternion.identity);
            timeToShoot = Time.time + fireDelay;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
