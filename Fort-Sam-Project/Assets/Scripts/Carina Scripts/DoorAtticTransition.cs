using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorAtticTransition : MonoBehaviour
{
    [SerializeField] GameObject doorOpen;
    [SerializeField] GameObject doorClosed;
    [SerializeField] GameObject blurryImage;
    [SerializeField] GameObject descendArrows;


    public void DoorOpen(bool keyPressed)
    {

        if (keyPressed && doorClosed.activeSelf)
        {
            doorOpen.SetActive(true);
            doorClosed.SetActive(false);
            blurryImage.SetActive(true);
            descendArrows.SetActive(false);
            Invoke(nameof(MoveToAttic), 0.2f);
        }
    }

    public void MoveToAttic()
    {
        SceneManager.LoadScene("Vinden");
    }

    public void DoorClosed()
    {
        doorClosed.SetActive(true);
        blurryImage.SetActive(true);
        descendArrows.SetActive(true);
    }

    public void MoveFromDoor()
    {
        blurryImage.SetActive(false);
        descendArrows.SetActive(false);

        if (doorClosed.activeSelf)
        {
            doorClosed.SetActive(false);
        }
    }
}
