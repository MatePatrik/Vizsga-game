using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
public class ShopCritRateText : MonoBehaviour
{
    public ClassLoader classLoader;
    public int price;
    public float critRate;
    public int coin;
    public Text priceText;
    public Text CritRateText;
    public Text coinText;
    private void Start()
    {
        GameObject logic = GameObject.FindGameObjectWithTag("LogicManager");
        classLoader=logic.GetComponent<ClassLoader>();
        priceText.text=price.ToString();
        CritRateText.text=critRate.ToString();
        if (classLoader.isKnight)
        {
            critRate=5;
        }
        else
        {
            critRate=10;
        }
    }
    private void Update()
    {
        price=int.Parse(priceText.text);
        coin=int.Parse(coinText.text);
    }
    public void CritRateBuy()
    {
        if (coin>=int.Parse(priceText.text))
        {
            coin -= int.Parse(priceText.text);
            coinText.text=coin.ToString();
            price*=2;
            priceText.text=price.ToString();
            critRate+=1;
            CritRateText.text=critRate.ToString();
        }
    }
}
