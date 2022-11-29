using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public void ChangetoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ChangetoGameScreen()
    {
        SceneManager.LoadScene("Game");
    }

    public void ChangetoGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void ChangetoCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void ChangetoQuit()
    {
        SceneManager.LoadScene("Quit");
        Application.Quit();
    }
}
