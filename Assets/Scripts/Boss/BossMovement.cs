using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public float speed = 3f;
    protected Rigidbody2D rigidBody;

    GameObject player;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        OnStart();
    }

    protected virtual void OnStart()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (player.transform.position.x < transform.position.x)
        {
            rigidBody.velocity = new Vector2(-3f, rigidBody.velocity.y);
        }
        else if (player.transform.position.x > transform.position.x)
        {
            rigidBody.velocity = new Vector2(3f, rigidBody.velocity.y);
        }
        else
        {
            //rigidBody.velocity = new Vector2(0f, rigidBody.velocity.y);
        }
    }
}
