using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamRoomTransition : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LevelManager.FindObjectOfType<LevelManager>().LoadLevel(1);
        }
    }
}
