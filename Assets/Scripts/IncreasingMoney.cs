using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class IncreasingMoney : MonoBehaviour
{
    [SerializeField] private TMP_Text _priceShower;
    [SerializeField] private Coin _coin;
    [SerializeField] private float _price;
    [SerializeField] private float _increasingMoney;

    public void TryingBuyUpgrade()
    {
        if (_coin.Money >= _price)
        {
            _coin.BuyUpgrade(_price);
            _coin.IncreaseMoneyEverySecond(_increasingMoney);
            _price *= 1.5f;
            _price = Convert.ToSingle(Math.Round(_price));
            _priceShower.text = _price.ToString();
        }
    }
}
