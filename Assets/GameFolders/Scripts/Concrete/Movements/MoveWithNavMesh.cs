using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveWithNavMesh : IMover
{
    NavMeshAgent _navMeshAgent;
    public MoveWithNavMesh( IEntityController entityController)
    {
        _navMeshAgent=entityController.transform.GetComponent<NavMeshAgent>();  
    }



    public void MoveAction(Vector3 direction, float movespeed)
    {

        _navMeshAgent.SetDestination(direction);
    }
}
