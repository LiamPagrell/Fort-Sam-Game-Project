using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SockScore : MonoBehaviour
{
    public TextMeshProUGUI sockText;
    public void UpdateSockText(int CollectedSocks)
    {
        sockText.text = "Socks collected: " +CollectedSocks;
    }
}
