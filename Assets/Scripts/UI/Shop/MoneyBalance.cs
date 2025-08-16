using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyBalance : MonoBehaviour
{
    [SerializeField] private TMP_Text _moneyBalance;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _moneyBalance.text = _player.Money.ToString();
    }
}
