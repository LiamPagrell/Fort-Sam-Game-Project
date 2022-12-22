using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{

    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject backpack;

    public static bool gameIsPaused;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
    }

    public void PauseGame()
    {
        if (gameIsPaused)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0f;        // stops time
            AudioListener.pause = true; // paus all music
            backpack.SetActive(false);
        }
        else
        {
            ResumeGame();
        }
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        AudioListener.pause = false;
        backpack.SetActive(true);
    }

    public void QuitToMenu()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        SceneManager.LoadScene("Menu");
        PickupBehaviour.ResetInventory();
        SceneManager.LoadScene("Menu");
    }
}
