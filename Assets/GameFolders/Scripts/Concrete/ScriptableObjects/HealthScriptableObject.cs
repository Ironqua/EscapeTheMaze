using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Health Info",menuName ="Health Information/Create New",order =51)]

public class HealthScriptableObject:ScriptableObject
{
    [SerializeField] int _maxHealth;

    public int MaxHealth => _maxHealth;
}
