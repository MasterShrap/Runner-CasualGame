using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int _coinCount;

    private void Start()
    {
        _coinCount = Progress.Instance.Coins;
    }

    public int CoinCount
    {
        get => _coinCount;
        set => _coinCount = value;
    }

    public void Save()
    {
        Progress.Instance.Coins = _coinCount;
    }
}
