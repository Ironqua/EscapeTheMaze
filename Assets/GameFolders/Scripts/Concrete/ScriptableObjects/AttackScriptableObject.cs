using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName ="Attack Info",menuName ="Attack Information/Create Menu",order =51)]

public class AttackScriptableObject : ScriptableObject
{

    [SerializeField] int damage = 25;
    [SerializeField] float _floatValue = 1f;
    [SerializeField] LayerMask _layerMask;
    [SerializeField] float _maxDelay = 0.25f;

    public int Damage => damage;
    public float FloatValue=> _floatValue;
    public LayerMask LayerMask => _layerMask;
    public float MaxDelay => _maxDelay;

    
}
