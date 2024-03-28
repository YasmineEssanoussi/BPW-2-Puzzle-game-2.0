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
    private int patrolIndex = 0;

    // Start is called before the first frame update
    private void Start()
    {
        //    navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.SetDestination(patrolPoints[patrolIndex].position);
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
        if(navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance) //als enemy bij patrolPunt is aangekomen
        {
            patrolIndex += 1; //dan naar de volgende patrolPunt lopen
            if(patrolIndex >= patrolPoints.Length)//Langs alle patrolPoint terug naar 0
            {
                patrolIndex = 0;
            }
            navMeshAgent.SetDestination(patrolPoints[patrolIndex].position);
        }
    }

}
