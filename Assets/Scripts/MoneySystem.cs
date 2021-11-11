using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneySystem : MonoBehaviour
{
    //Money variables
    
   
    public int crackPrice;
    private CoinSystem PengeScript; 

    public Transform Player;
    public float Distance;
    public float IndenforRange;
    public TextMesh SellText;
    public GameObject GameManager;
    public float coolDownValue = 5.0f;
    [SerializeField]
    bool isSelling = false;


    // Start is called before the first frame update

    public void Awake()
    {
        GameManager = GameObject.Find("GameManager");
        PengeScript = GameManager.GetComponent<CoinSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Distance = Vector3.Distance(transform.position, Player.position);
        {
            if (Distance <= IndenforRange)
            {
                SellText.gameObject.SetActive(true);
                if(Input.GetButton ("SellButton") && isSelling == false)
                {
                    PengeScript.totalMoney = PengeScript.totalMoney + crackPrice;
                    
                    StartCoroutine(CoolDown());


                    

                }

            }
            else
            {

                SellText.gameObject.SetActive(false);

            }

        }

    }

    IEnumerator CoolDown()
    {
        isSelling = true;
        yield return new WaitForSeconds(coolDownValue);
        isSelling = false;
    }

    
}
