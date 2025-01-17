using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{

    
    public int health = 100;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Something hit me!");
        health -= 10;
        Debug.Log(health);
        if (health <= 0)
        {
            Debug.Log("Dead");
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
   
}
