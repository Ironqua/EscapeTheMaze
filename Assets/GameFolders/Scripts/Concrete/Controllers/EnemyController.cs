using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour, IEntityController
{
    [SerializeField] Transform _playerPrefab;
    IMover _mover;
    IHealth health;
    ChracterAnimation _characterAnimation;
    NavMeshAgent agent;
    private void Awake()
    {
        _mover = new MoveWithNavMesh(this);
        _characterAnimation=new ChracterAnimation(this);
        agent=GetComponent<NavMeshAgent>(); 
        health=GetComponent<IHealth>();
    }
    private void Update()
    {
        if (health.IsDead) return;
        _mover.MoveAction(_playerPrefab.transform.position,10f);
        
    }
    private void LateUpdate()
    {
        _characterAnimation.MoveAnimation(agent.velocity.magnitude);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("hit");
        }


        
    }
}
