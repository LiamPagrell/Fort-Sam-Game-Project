using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.FlowStateWidget;

public class Player : MonoBehaviour
{
    [SerializeField] AnimationClip clip;
    [SerializeField] float eventTime;
    void Start()
    {
        clip.AddAnimationEvent(eventTime, "OnplayerOnTop");
    }

    void OnplayerOnTop()
    {
        Debug.Log("player On Top");
    }
}
