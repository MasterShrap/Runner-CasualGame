using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBihaviour : MonoBehaviour
{
    [SerializeField] private PlayerMove _playerMove;
    [SerializeField] private PreFinish _preFinish;
    [SerializeField] private Animator _animator;


    void Start()
    {
        StopMove();
    }

    public void StopMove()
    {
        _playerMove.enabled = false;
        _preFinish.enabled = false;
    }

    public void Play()
    {
        _playerMove.enabled = true;
    }

    public void Dance()
    {
        _preFinish.enabled = false; 
        _animator.SetTrigger("Dance");
    }

    public void PreFinishRun()
    {
        _playerMove.enabled = false;
        _preFinish.enabled = true;
    }
}
