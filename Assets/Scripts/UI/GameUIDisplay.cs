using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameUIDisplay : Damageable
{
    VisualElement root;
    Label healthDisplay;

    public Damageable playerHealth;

    private void Awake()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        healthDisplay = root.Q<Label>("health-display");
    }

    private void FixedUpdate()
    {
        healthDisplay.text = "Health: " + playerHealth.health.ToString();
    }
}
