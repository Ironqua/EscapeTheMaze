using Assets.GameFolders.Scripts.Abstract.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorCharacterY : IRotator
{
    Transform _transform;
    float _tilt;
    public RotatorCharacterY(PlayerController playerController)
    {
        _transform = playerController.turnTransform;
    }

    

    public void RotationAction(float direction, float speed)
    {
        direction*=speed*Time.deltaTime;
        _tilt = Mathf.Clamp(_tilt - direction, -60f, 60f);
        _transform.localRotation = Quaternion.Euler(_tilt, 0f, 0f);

    }
}
