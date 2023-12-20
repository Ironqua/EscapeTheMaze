using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour, IHealth
{
    [SerializeField] HealthScriptableObject _healthInfo;
    int _currentHealth;

    public bool IsDead => _currentHealth <= 0;

    private void Awake()
    {
        _currentHealth = _healthInfo.MaxHealth;

    }
    public void TakeDamage(int damage)
    {
        if(IsDead) return;

       _currentHealth-=damage;   
    }
}
