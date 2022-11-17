using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeformation : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    [SerializeField] private Transform _topSpine;
    [SerializeField] private Transform _bottomSpine;
    [SerializeField] private Transform _collider;
    [SerializeField] private Animator _animator;
    [SerializeField] private PlayerBihaviour _bihaviour;
    [SerializeField] private CoinManager _coinManager;

    private int _width;
    private int _height;

    private float _widthMultiplier = 0.0005f;
    private float _heightMultiplier = 0.01f;

    private void Awake()
    {
        AddWidth(Progress.Instance.Width);
        AddHeight(Progress.Instance.Height + 10);
    }

    public void AddWidth(int value)
    {
        _width += value;
        UpdateWidth();
    }

    public void AddHeight(int value)
    {
        _height += value;
        
        _topSpine.position = _bottomSpine.position + new Vector3(0, _heightMultiplier * _height, 0);

        _collider.localScale = new Vector3(1, 0.9f + _heightMultiplier * _height, 1);
    }

    public void HitBarrier()
    {
        if((_width + _height) - 50 > 0)
        {
            AddWidth(-30);
            AddHeight(-30);
        }
        else
        {
            _animator.SetBool("Die", true);
            _bihaviour.StopMove();
            StartCoroutine(RestartGame());
        }
    }

    private void UpdateWidth()
    {
        _renderer.material.SetFloat("_PushValue", _width * _widthMultiplier);
    }

    private IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
