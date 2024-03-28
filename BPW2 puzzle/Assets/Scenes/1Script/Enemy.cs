using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public enum StateENum { Idle, Patrol, Attack }
    public StateENum state;
    public NavMeshAgent navMeshAgent;
    public Transform[] patrolPoints;

    // Start is called before the first frame update
    private void Start()
    {
    //    navMeshAgent = GetComponent<NavMeshAgent>();
    }


    // Update is called once per frame
    private void Update()
    {
        CheckState();
    }


    private void CheckState()
    {
        switch (state)
        {
            case StateENum.Attack: AttackBehaviour(); break;
            case StateENum.Idle: IdleBehaviour(); break;
            case StateENum.Patrol: PatrolBehaviour(); break;
        }
    }


    private void AttackBehaviour()
    {

    } 


    private void IdleBehaviour()
    { 
    }


    private void PatrolBehaviour()
    {
        navMeshAgent.SetDestination(patrolPoints[0].position);
    }

}
