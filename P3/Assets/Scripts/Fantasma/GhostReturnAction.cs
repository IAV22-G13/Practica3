using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;

/*
 * Accion de ir a la sala de musica, cuando llega devuelve Success
 */

public class GhostReturnAction : Action
{
    NavMeshAgent agent;
    GameObject musicRoom;

    public override void OnAwake()
    {
        agent = GetComponent<NavMeshAgent>();
        musicRoom = GameObject.FindGameObjectWithTag("Blackboard").GetComponent<GameBlackboard>().musicRoom;
    }

    public override TaskStatus OnUpdate()
    {
        if(agent.enabled)
            agent.SetDestination(musicRoom.transform.position);
        if (Vector3.SqrMagnitude(transform.position - musicRoom.transform.position) < 1.5f)
        {
            agent.SetDestination(transform.position);
            return TaskStatus.Success;
        }
        else return TaskStatus.Running;
    }
}