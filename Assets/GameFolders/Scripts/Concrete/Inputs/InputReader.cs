using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour,IInputReader
{

    public Vector3 Direction { get; private set; }
    public Vector2 Rotation { get; private set; }
    public bool ýsAttackButtonPress { get;private set; }


    public void  OnMove(InputAction.CallbackContext context)

    {
        Vector3 oldDirection = context.ReadValue<Vector3>();
        Direction=new Vector3(oldDirection.x,0f,oldDirection.y);
    }

    public void OnRotator(InputAction.CallbackContext context)

    {
        Rotation =context.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext context)

    {
        ýsAttackButtonPress = context.ReadValueAsButton();
    }


}


