using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChracterAnimation : MonoBehaviour
{
    Animator _animator;


    public ChracterAnimation(IEntityController entity)
    {
        _animator = entity.transform.GetComponentInChildren<Animator>();
    }

    public void MoveAnimation(float movespeed)
    {
        if (_animator.GetFloat("moveSpeed") == movespeed) return;
        _animator.SetFloat("moveSpeed", movespeed,0.1f,Time.deltaTime);
    }

    public void AttackAnimation(bool canAttack)

    {
        _animator.SetBool("isAttack", canAttack);
    }
}
