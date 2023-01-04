using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingRoomTransition : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LevelManager.FindObjectOfType<LevelManager>().LoadLevel(3);
        }
    }
}