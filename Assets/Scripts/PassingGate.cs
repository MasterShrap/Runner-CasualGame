using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassingGate : MonoBehaviour
{
    [SerializeField] private GameObject _passingGate;
    [SerializeField] private Gate _gate;
    [SerializeField] private PlayerDeformation _player;

    private void OnTriggerEnter(Collider other)
    {
        if (_gate.DeformationType == DeformationType.Width)
        {
            _player.AddWidth(_gate.Value);
        }
        else
        {
            _player.AddHeight(_gate.Value);
        }
        Destroy(_passingGate);
    }



}
