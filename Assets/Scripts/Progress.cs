using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    [SerializeField] public int Coins { get; set; }
    [SerializeField] public int Width { get; set; }
    [SerializeField] public int Height { get; set; }

    public static Progress Instance;
    
    private void Awake()
    {
        if (Instance == null)
        {
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }
}
