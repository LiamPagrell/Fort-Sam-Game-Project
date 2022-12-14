using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SockScore : MonoBehaviour
{
    public Text sockText;
    public void UpdateSockText(int CollectedSocks)
    {
        sockText.text = "Socks collected: " +CollectedSocks;
    }
}
