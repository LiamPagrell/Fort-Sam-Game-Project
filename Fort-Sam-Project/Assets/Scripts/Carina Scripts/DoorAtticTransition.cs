using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorAtticTransition : MonoBehaviour
{
    [SerializeField] GameObject doorOpen;
    [SerializeField] GameObject doorClosed;
    [SerializeField] GameObject blurryImage;


    public void DoorOpen(bool keyPressed)
    {

        if (keyPressed && doorClosed.activeSelf)
        {
            doorOpen.SetActive(true);
            doorClosed.SetActive(false);
            blurryImage.SetActive(true);
        }
    }

    public void DoorClosed()
    {
        doorClosed.SetActive(true);
        blurryImage.SetActive(true);
    }

    public void MoveToAttic()
    {
        SceneManager.LoadScene("Vinden");
    }

    public void MoveFromDoor()
    {
        blurryImage.SetActive(false);

        if (doorClosed.activeSelf)
        {
            doorClosed.SetActive(false);
        }
        else if (doorOpen.activeSelf)
        {
            doorOpen.SetActive(false);
        }
    }
}
