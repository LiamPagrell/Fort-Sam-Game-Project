using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCounter : MonoBehaviour
{
    [SerializeField]
    private int CollectedSocks = 0;
    public SockScore sockScore;

    //public static CollectableCounter Counter;

    public void AddSocks()
    {
        CollectedSocks++;
        Debug.Log("Collected a Sock, You now you have " + CollectedSocks + " Socks collected");
    }

    public void Update()
    {
        sockScore.UpdateSockText(CollectedSocks);
    }
}
