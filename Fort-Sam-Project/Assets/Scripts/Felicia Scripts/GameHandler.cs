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

    public void ChangetoIntro()
    {
        SceneManager.LoadScene("Intro");

    }
    public void ChangetoGameScreen()
    {
        SceneManager.LoadScene("SamRoom");
        
    }

    public void ChangetoCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void ChangetoControlls()
    {
        SceneManager.LoadScene("Controlls");
    }
    public void ChangetoQuit()
    {
        SceneManager.LoadScene("Quit");
        Application.Quit();
    }
}
