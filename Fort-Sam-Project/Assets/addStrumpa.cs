using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addStrumpa : MonoBehaviour
{
    public strumpaList strump;
    public string strumpValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {   
            strump.amountOfPickedUpSocks.Add(strumpValue);
            Debug.Log(strump.amountOfPickedUpSocks);       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
