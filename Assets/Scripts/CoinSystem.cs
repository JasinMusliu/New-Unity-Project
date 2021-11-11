using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinSystem : MonoBehaviour


{

    public Text moneyTxt;
    public int totalMoney;
    public Text SecondsText;
    bool test;

    public float Seconds;
    public string _Seconds;
    public float AddSeconds;

    // Start is called before the first frame update
    void Start()
    {
        totalMoney = 0;
    }

    void Update()

    {
        Seconds -= Time.deltaTime;
        _Seconds = Seconds.ToString("F0");
        SecondsText.text = "Time " + _Seconds;
        moneyTxt.text = "$ " + totalMoney.ToString();

        if(Seconds <= 0)
        {
           
            SecondsText.text = "Time 0";

        }

    }


    // Update is called once per frame
    
    void UpdateTotalMoney()
    {

        moneyTxt.text = "$ " + totalMoney.ToString();

    }


}



