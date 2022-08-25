using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenuUI : MonoBehaviour
{
    public TextMeshProUGUI HighScoreText;

    private int highScore;
    private string playerName;

    private void Start()
    {
        GameManager.Instance.LoadScore();
        UpdateHighScoreText();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    private void UpdateHighScoreText()
    {
        highScore = GameManager.Instance.HighScore;
        playerName = GameManager.Instance.BestPlayer;

        HighScoreText.text = "Best Score: " + playerName + ": " + highScore;
    }
}
