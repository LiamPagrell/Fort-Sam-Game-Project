using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockMiscDist : MonoBehaviour
{
    public GameObject zoomedNull;
    public GameObject zoomObject;
    public GameObject buttons;
    public GameObject closeZO1, closeZO2, closeZO3; /// Create a separate gameObject that is an empty object just to fill in the blanks that you might get if you have less than 3 zoomed objects that needs closing i.e closeZO
    Movement player;
    public ParticleSystem konfetti;
    public SoundManager soundManager;

    float checkDistance;
    public float pickUpDistance = 3.4f;

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
            CloseZoomedObj();
        }
    }
    public void CloseZoomedObj()
    {
        if (zoomedNull != null)
        {
            if (!zoomObject.activeSelf)
            {
                bool isActive = zoomedNull.activeSelf;
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
