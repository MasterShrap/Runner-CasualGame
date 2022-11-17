using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed;
    
    private float _directionX;
    private float _directionZ;
    private float eulerY;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        _directionX = _joystick.Horizontal * _speed * Time.deltaTime;
        _directionZ = _joystick.Vertical * _speed * Time.deltaTime;

        if( _directionZ != 0)
        {
            _animator.SetBool("Run", true);

            Vector3 newPosition = transform.position + transform.forward * _speed * Time.deltaTime;
            
            newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
            
            transform.position = newPosition;
        }
        else
        {
            _animator.SetBool("Run", false);
        }

        eulerY += _directionX * 30;
        eulerY = Mathf.Clamp(eulerY, -90, 90);

        transform.eulerAngles = new Vector3(0, eulerY, 0);
    }
}
