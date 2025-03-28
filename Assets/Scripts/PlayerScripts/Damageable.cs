using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damageable : MonoBehaviour
{

    
    public int health = 100;

    public float invincibilityTime = 0.5f;
    float clock = 0f;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (Time.time > clock)
        {
            
            Debug.Log("Something hit me!");
            health -= 10;
            Debug.Log(health);
            clock = Time.time + invincibilityTime;

            if (health <= 0)
            {
                Debug.Log("Dead");
                SceneManager.LoadScene("MainMenu");
                /*Application.Quit();
                UnityEditor.EditorApplication.isPlaying = false;*/
            }
        }
    }
   
}
