using System.Collections;
using System.Collections.Generic;
//using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SockCounter : MonoBehaviour
{
    //int counter;
    //[SerializeField] GameObject sock;
    //[SerializeField] GameObject sockUI;

    public GameObject[] socks; 

    //public SoundManager soundManager;


    void Start()
    {
        UpdateSockUI();
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Menu")
        {
            Debug.Log("Resetting ALL player prefs");
            PlayerPrefs.DeleteAll();
        }
    }

    private void UpdateSockUI()
    {
        for (int i = 0; i < socks.Length; i++)
        {

            if (PlayerPrefs.GetInt("strumpa-" + i) == 1)
            {
                socks[i].SetActive(true);
            }
        }
    }

    private void OnEnable()
    {
        UpdateSockUI();
    }
}
