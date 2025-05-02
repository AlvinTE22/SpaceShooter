using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{

    public int health = 250;

    public float invincibilityTime = 0.5f;
    float clock = 0f;

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (Time.time > clock)
        {
            health -= 10;
            Debug.Log(health);
            clock = Time.time + invincibilityTime;

            if (health <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
