using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class KitchenLockCode : MonoBehaviour
{
    public SoundManager soundManager;
    public GameObject escape;
    [SerializeField] GameObject fridgeImage;

    int code = 1518;

    [SerializeField] TextMeshProUGUI textObject1;
    [SerializeField] TextMeshProUGUI textObject2;
    [SerializeField] TextMeshProUGUI textObject3;
    [SerializeField] TextMeshProUGUI textObject4;
    int counter1 = 1;
    int counter2 = 1;
    int counter3 = 1;
    int counter4 = 1;


    public int GetRealNumber(int counter)
    {
        while (counter < 0)
        {
            counter += 10;
        }
        return counter % 10;
    }

    public void ChangeFirstCounter(int amount)
    {
        counter1 += amount;
        textObject1.text = $"{GetRealNumber(counter1)}";
        CheckCode();
    }
    public void ChangeSecondCounter(int amount)
    {
        counter2 += amount;
        textObject2.text = GetRealNumber(counter2).ToString();
        CheckCode();
    }
    public void ChangeThirdCounter(int amount)
    {
        counter3 += amount;
        textObject3.text = GetRealNumber(counter3).ToString();
        CheckCode();
    }
    public void ChangeFourthCounter(int amount)
    {
        counter4 += amount;
        textObject4.text = GetRealNumber(counter4).ToString();
        CheckCode();
    }

    public void CheckCode()
    {
        int number = GetRealNumber(counter1) * 1000 + GetRealNumber(counter2) * 100 + GetRealNumber(counter3) * 10 + GetRealNumber(counter4);
        if (number == code)
        {
            StartCoroutine(WinCLosePanel());
            //find the chest, turn it off
            var chest = FindObjectOfType<UnlockChest>();
            chest.open = true;
            //Turn of chest cursor interactable as well
            chest.gameObject.GetComponent<Collider2D>().enabled = false;
            escape.SetActive(false);
        }
    }

    IEnumerator WinCLosePanel()
    {
        yield return new WaitForSeconds(0.3f);
        UnlockChest.FindObjectOfType<UnlockChest>().CloseLockWindow();
        //UnlockChest.FindObjectOfType<UnlockChest>().GetComponent<Animator>().Play("ChestOpen");
        //soundManager.Treasure();
        fridgeImage.SetActive(true);
        GetComponent<RectTransform>().gameObject.SetActive(false);
    }

}
