using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] bool _canFire;
    [SerializeField] Transform transformObject;
  
    [SerializeField] AttackScriptableObject _attackSO;

    [SerializeField] Camera _camera;
    

    float _currentTime;
    IAttackType _attackType;
    private void Awake()
    {
        _attackType = new RangeAttackType(_camera.transform, _attackSO);
    }
    private void Update()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime < _attackSO.MaxDelay ) _canFire = true;

    }

    public void Attack()
    { if (!_canFire) return;

      
        _attackType.AttackAction();
        _currentTime = 0f;
        _canFire = false;
    }

}
