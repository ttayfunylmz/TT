using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void About()
    {
        SceneManager.LoadScene("AboutScene");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting..");
        Application.Quit();
    }
}
