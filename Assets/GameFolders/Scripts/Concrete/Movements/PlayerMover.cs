using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : IMover
{
    CharacterController characterController;
    
    public PlayerMover(IEntityController entityController)
    {
       characterController= entityController.transform.GetComponent<CharacterController>();
    }
 
    public void MoveAction(Vector3 direction,float movespeed)
    {
        if(direction==Vector3.zero) return;
        Vector3 worldPos= characterController.transform.TransformDirection(direction);
        Vector3 movement=worldPos*movespeed*Time.deltaTime;
        characterController.Move(movement);
    }
}
