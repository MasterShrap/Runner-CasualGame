using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private CoinManager _coinManager;
    [SerializeField] PlayerDeformation _playerDeformation;

    public void ByeWidth()
    {
        if(_coinManager.CoinCount >= 50)
        {
            _coinManager.CoinCount -= 50;
            _coinManager.Save();
            _coin.CoinsText = $"Coins: {_coinManager.CoinCount}";
            _playerDeformation.AddWidth(20);
            Progress.Instance.Width += 20;
        }
    }

    public void ByeHeight()
    {
        if (_coinManager.CoinCount >= 50)
        {
            _coinManager.CoinCount -= 50;
            _coinManager.Save();
            _coin.CoinsText = $"Coins: {_coinManager.CoinCount}";
            _playerDeformation.AddHeight(20);
            Progress.Instance.Height += 10;
        }
    }
}
