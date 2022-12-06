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
        Debug.Log("You quit");
    }
}
