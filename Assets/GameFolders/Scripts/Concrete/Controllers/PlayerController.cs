using Assets.GameFolders.Scripts.Abstract.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayerController : MonoBehaviour, IEntityController
{
    float movespeed = 10f;
  IInputReader _inputReader;
    IMover _mover;
    Vector3 _direction;
 //   Vector2 _rotation;
    ChracterAnimation _animation;
    [SerializeField] float _turnspeed = 7f;
    [SerializeField] Transform _turnTransform;
    [SerializeField] WeaponController _currentWeapon;

    IRotator _xRotator;
    IRotator _yRotator;



    public Transform turnTransform=> _turnTransform;
    private void Awake()
    {
        _inputReader = GetComponent<IInputReader>();
        _mover=new PlayerMover(this);
        _animation = new ChracterAnimation(this);
        _xRotator = new RotatorCharacterX(this);
        _yRotator=new RotatorCharacterY(this);


    }

    private void Update()
    {
        Debug.Log(_inputReader.Direction);
        _direction= _inputReader.Direction;
    //    _rotation= _inputReader.Rotation;

        _xRotator.RotationAction(_inputReader.Rotation.x, _turnspeed);
        _yRotator.RotationAction(_inputReader.Rotation.y, _turnspeed);

        if (_inputReader.ýsAttackButtonPress)
        {
            _currentWeapon.Attack();
        }

    }

    private void FixedUpdate()
    {
        _mover.MoveAction( _direction,movespeed );
      
    }

    private void LateUpdate()
    {
        _animation.MoveAnimation(_direction.magnitude);
        _animation.AttackAnimation(_inputReader.ýsAttackButtonPress);
    }
}
