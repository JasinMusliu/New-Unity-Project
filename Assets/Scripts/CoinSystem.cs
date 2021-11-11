using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinSystem : MonoBehaviour



{

    public Text moneyTxt;
    public int totalMoney;
    bool test;


    // Start is called before the first frame update
    void Start()
    {
        totalMoney = 0;
    }

    void Update()

    {
        
        moneyTxt.text = "$ " + totalMoney.ToString();
    }


    // Update is called once per frame
    
    void UpdateTotalMoney()
    {
        moneyTxt.text = "$ " + totalMoney.ToString();
    }

 
}



