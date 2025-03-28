using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenuController : MonoBehaviour
{
    VisualElement root;
    Button startButton;
    Button quitButton;

    private void Awake()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        startButton = root.Q<Button>("start-button");
        startButton.RegisterCallback<ClickEvent>(OnStartButtonClicked);

        quitButton = root.Q<Button>("quit-button");
        quitButton.RegisterCallback<ClickEvent>(OnQuitButtonClicked);
    }

    private void OnDisable()
    {
        startButton.UnregisterCallback<ClickEvent>(OnStartButtonClicked);
        quitButton.UnregisterCallback<ClickEvent>(OnQuitButtonClicked);
    }

    void OnStartButtonClicked(ClickEvent evt)
    {
        print("Start button was clicked");
        SceneManager.LoadScene("MainGame");
    }

    void OnQuitButtonClicked(ClickEvent evt) {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
