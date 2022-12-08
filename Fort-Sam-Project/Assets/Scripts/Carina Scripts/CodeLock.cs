using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodeLock : MonoBehaviour
{

    int code = 3118;
    string nr = null;
    int nrIndex = 0;
    string alpha;
    public TextMeshProUGUI uiText = null;
    [SerializeField] TextMeshProUGUI textObject1;
    [SerializeField] TextMeshProUGUI textObject2;
    [SerializeField] TextMeshProUGUI textObject3;
    [SerializeField] TextMeshProUGUI textObject4;
    int counter1;
    int counter2;
    int counter3;
    int counter4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetRealNumber(int counter)
    {
        return (counter % 9) + 1;
    }

    public void ChangeFirstCounter(int amount)
    {
        Debug.Log("heo");
        counter1 += amount;
        textObject1.text = $"{GetRealNumber(counter1)}";
        CheckCode();
    }
    public void ChangeSecondCounter(int amount)
    {
        Debug.Log("heo");
        counter2 += amount;
        textObject2.text = GetRealNumber(counter2).ToString();
        CheckCode();
    }
    public void ChangeThirdCounter(int amount)
    {
        Debug.Log("heo");
        counter3 += amount;
        textObject3.text = GetRealNumber(counter3).ToString();
        CheckCode();
    }
    public void ChangeFourthCounter(int amount)
    {
        Debug.Log("heo");
        counter4 += amount;
        textObject4.text = GetRealNumber(counter4).ToString();
        CheckCode();
    }

    public void CheckCode()
    {
        int number = GetRealNumber(counter1) * 1000 + GetRealNumber(counter2) * 100 + GetRealNumber(counter3) * 10 + GetRealNumber(counter4);
        if(number == code)
        {
            Debug.Log("Hackermans, im in!");
        }
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
