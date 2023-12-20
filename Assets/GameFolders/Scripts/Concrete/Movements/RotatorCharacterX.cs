using Assets.GameFolders.Scripts.Abstract.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorCharacterX : IRotator
{

    PlayerController _playerController;

    public RotatorCharacterX(PlayerController playerController)
    {
        _playerController = playerController;   
    }
    public void RotationAction(float direction,float speed)
    {
        _playerController.transform.Rotate(Vector3.up*direction*speed*Time.deltaTime);

    }
}
