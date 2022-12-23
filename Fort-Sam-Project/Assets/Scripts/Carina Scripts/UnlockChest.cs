using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockChest : MonoBehaviour
{
    public GameObject lockPanel;
    public GameObject zoomObject;
    public GameObject buttons;
    public GameObject closeZO1, closeZO2, closeZO3;
    Movement player;

    float checkDistance;
    float pickUpDistance = 3.4f;

    public bool open = false;

    private void Start()
    {
        player = FindObjectOfType<Movement>();
    }

    private void OnMouseDown()
    {
        checkDistance = Vector2.Distance(this.transform.position, player.transform.position);

        if (checkDistance < pickUpDistance && !open)
        {
            CloseLockWindow();
        }
    }
    public void CloseLockWindow()
    {
        if (lockPanel != null)
        {
            if (!zoomObject.activeSelf)
            {
                bool isActive = lockPanel.activeSelf;
                zoomObject.SetActive(!isActive);
                buttons.SetActive(false);
                closeZO1.SetActive(false);
                closeZO2.SetActive(false);
                closeZO3.SetActive(false);

                StartCoroutine(wait());

            }
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);
        buttons.SetActive(true);

    }
}
