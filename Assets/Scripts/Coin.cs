using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinsCountText;
    [SerializeField] private GameObject _particleCoin;

    private float _rotationSpeed;

    private void Start()
    {
        _coinsCountText.text = $"Coins: {Progress.Instance.Coins}";
    }

    void FixedUpdate()
    {
        _rotationSpeed = 180 * Time.deltaTime;
        transform.Rotate(0, _rotationSpeed , 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CoinManager>().CoinCount += 1;
        _coinsCountText.text = $"Coins: {FindObjectOfType<CoinManager>().CoinCount}";
        Destroy(gameObject);
        Instantiate(_particleCoin, gameObject.transform.position, Quaternion.identity);
    }

    public string CoinsText
    {
        get => _coinsCountText.text;
        set => _coinsCountText.text = value;
    }
}
