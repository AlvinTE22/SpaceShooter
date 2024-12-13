using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenuController : MonoBehaviour
{
    VisualElement root;
    Button startButton;

    private void Awake()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        startButton = root.Q<Button>("start-button");
        startButton.RegisterCallback<ClickEvent>(OnStartButtonClicked);
    }

    private void OnDisable()
    {
        startButton.UnregisterCallback<ClickEvent>(OnStartButtonClicked);
    }

    void OnStartButtonClicked(ClickEvent evt)
    {
        print("Start button was clicked");
        SceneManager.LoadScene("MainGame");
    }
}
