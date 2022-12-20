using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Coin : MonoBehaviour
{
    [SerializeField] private TMP_Text _moneyShower;
    [SerializeField] private TMP_Text _moneyPerSecondShower;

    public float Money { get; private set; }

    private float _addingMoneyEverySecond;
    private float _addingMoneyEveryClick = 1f;   
    private int _delay = 1;
    private float _lastMoneyIncrease;

    public void ClickCoin()
    {
        Money += _addingMoneyEveryClick;
        _moneyShower.text = Money.ToString();
    }

    private void Update()
    {
        if (_lastMoneyIncrease <= 0)
        {
            Money += _addingMoneyEverySecond;
            Money = Convert.ToSingle(Math.Round(Money, 1));
            _lastMoneyIncrease = _delay;
            _moneyShower.text = Money.ToString();
        }
        
        _lastMoneyIncrease-= Time.deltaTime;
    }

    public void IncreaseMoneyEverySecond(float increasingMoney)
    {
        _addingMoneyEverySecond += increasingMoney;
        _moneyPerSecondShower.text = _addingMoneyEverySecond.ToString();
    }

    public void BuyUpgrade(float Price)
    {
        Money -= Price;
        Money = Convert.ToSingle(Math.Round(Money, 1));
        _moneyShower.text = Money.ToString();
    }
}
