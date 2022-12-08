using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodeLock : MonoBehaviour
{

    string code = "123";
    string nr = null;
    int nrIndex = 0;
    string alpha;
    public TextMeshProUGUI uiText = null;

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
        //textOnject1.text = counter.ToString();

    }

    public void CodeFunction(string numbers)
    {
        nrIndex++;
        nr = nr + numbers;
        uiText.text = nr;
    }

    public void Enter()
    {
        if (nr == code)
        {
            // kommer ur scenen
        }
    }

    public void Delete() // Maybe not needed
    {
        nrIndex++;
        nr = null;
        uiText.text = nr;
    }
}
