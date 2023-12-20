using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeAttackType : IAttackType
{
    AttackScriptableObject _attackSO;
     Camera _camera;
     
    public RangeAttackType(Transform transformobject, AttackScriptableObject attackSO)
    {
       
        _camera = transformobject.GetComponent<Camera>();
       _attackSO = attackSO;

    }
   
    public void AttackAction()
    {
        Ray ray = _camera.ViewportPointToRay(Vector3.one / 2f);

        if (Physics.Raycast(ray, out RaycastHit hitinfo, _attackSO.FloatValue, _attackSO.LayerMask))
        {
            IHealth health = hitinfo.collider.GetComponent<Health>();
            if (health != null)
            {
                health.TakeDamage(_attackSO.Damage);
            }


            Debug.Log(hitinfo.collider.gameObject.name);
        }
    }
}
