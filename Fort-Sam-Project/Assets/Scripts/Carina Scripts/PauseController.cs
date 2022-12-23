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
            if (!gameIsPaused)
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;        // stops time
        AudioListener.pause = true; // paus all music
        backpack.SetActive(false);
        gameIsPaused = true;
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        AudioListener.pause = false;
        backpack.SetActive(true);
        gameIsPaused = false;
    }

    public void QuitToMenu()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        PickupBehaviour.ResetInventory();
        SceneManager.LoadScene("Menu");
        gameIsPaused = false;
    }
}
