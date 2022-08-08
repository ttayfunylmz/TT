using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    public static int score; //making this static because we want it so be reachable from another scripts

    private void Start() 
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    private void Update() 
    {
        if(score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);
        }
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

}