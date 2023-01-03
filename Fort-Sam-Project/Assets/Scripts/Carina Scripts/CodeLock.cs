using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CodeLock : MonoBehaviour
{
    public SoundManager soundManager;

    int code = 1518;
    string nr = null;
    int nrIndex = 0;
    string alpha;
    public TextMeshProUGUI uiText = null;
    [SerializeField] TextMeshProUGUI textObject1;
    [SerializeField] TextMeshProUGUI textObject2;
    [SerializeField] TextMeshProUGUI textObject3;
    [SerializeField] TextMeshProUGUI textObject4;
    int counter1 = 1;
    int counter2 = 1;
    int counter3 = 1;
    int counter4 = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
        if(number == code)
        {
            //StartCoroutine(WinCLosePanel());
            Invoke(nameof(WinCLosePanel), 0.1f);
            //find the chest, turn it off
            var chest = FindObjectOfType<UnlockChest>();
            chest.open = true;
            chest.UnlockMovement();
            //Turn of chest cursor interactable as well
            chest.gameObject.GetComponent<Collider2D>().enabled = false;
            

        }
    }

    public void WinCLosePanel()
    {
        var chest = FindObjectOfType<UnlockChest>();
        //yield return new WaitForSeconds(0.5f);
        UnlockChest.FindObjectOfType<UnlockChest>().CloseLockWindow();
        UnlockChest.FindObjectOfType<UnlockChest>().GetComponent<Animator>().Play("ChestOpen");
        soundManager.Treasure();
        GameObject.Find("Remote").GetComponent<Animator>().SetTrigger("RemoteAppear");
        chest.konfetti.gameObject.SetActive(true);
        GameObject.Find("TransitionRemote").GetComponent<Animator>().SetTrigger("RemoteOut");

        GetComponent<RectTransform>().gameObject.SetActive(false);
    }




    public void CodeFunction(string numbers)
    {
        nrIndex++;
        nr = nr + numbers;
        uiText.text = nr;
    }

    public void Enter()
    {
        //if (nr == code)
        //{
        //    // kommer ur scenen
        //}
    }

    public void Delete() // Maybe not needed
    {
        nrIndex++;
        nr = null;
        uiText.text = nr;
    }
}
