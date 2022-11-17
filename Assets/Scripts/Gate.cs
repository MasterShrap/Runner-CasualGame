using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] private DeformationType _deformationType;
    [SerializeField] private int _value;
    [SerializeField] private Gates _gates;

    private void OnValidate()
    {
        _gates.UpdateVisual(_deformationType, _value);
    }

    public int Value
    {
        get=> _value;
        set => _value = value;
    }

    public DeformationType DeformationType
    {
        get => _deformationType;
        set => _deformationType = value;
    }
}
