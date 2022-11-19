using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFinish : MonoBehaviour
{
    private float _preFinishPosition;
    private float _preFinishRotation;

    void Update()
    {
        _preFinishPosition = Mathf.MoveTowards(transform.position.x, 0, 5 * Time.deltaTime);
        _preFinishRotation = Mathf.MoveTowardsAngle(transform.eulerAngles.y, 0, 50 * Time.deltaTime);

        transform.position = new Vector3(_preFinishPosition, 0, transform.position.z + 3 * Time.deltaTime);
        transform.localEulerAngles = new Vector3(0, _preFinishRotation, 0);
    }


}
