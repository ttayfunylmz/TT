using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreDisplayText;
    [SerializeField] private TMP_Text highScoreDisplayText;
    [SerializeField] private AudioSource dyingAudioSource;

    private void Start()
    {
        HighScoreDisplay();
        ScoreDisplay();
        dyingAudioSource.Play();
    }

    private void ScoreDisplay()
    {
        scoreDisplayText.text = "Your Score : " + GameManager.score;
    }

    private void HighScoreDisplay()
    {
        highScoreDisplayText.text = "High Score : " + PlayerPrefs.GetInt("highScore").ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
        BackgroundMusic.instance.gameObject.GetComponent<AudioSource>().UnPause();
    }
}
