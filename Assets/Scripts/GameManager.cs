using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _levelText;
    void Start()
    {
        _levelText.text = $"Level {SceneManager.GetActiveScene().buildIndex + 1}";
    }
}
