using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;

/*
 * Accion de accionar una palanca de los candelabros (la mas cercana), cuando la alcanza devuelve Success
 */

public class GhostPalancaAction : Action
{
    NavMeshAgent agent;
    GameObject lever;
    GameObject lever2;
    GameBlackboard blackboard;
    public override void OnAwake()
    {
        agent = GetComponent<NavMeshAgent>();
        blackboard = GameObject.FindGameObjectWithTag("Blackboard").GetComponent<GameBlackboard>();
        lever = blackboard.nearestLever(this.gameObject).transform.GetChild(0).gameObject;
        lever2 = blackboard.farestLever(this.gameObject).transform.GetChild(0).gameObject;
    }

    public override TaskStatus OnUpdate()
    {
        var navHit = new NavMeshHit();
        NavMesh.SamplePosition(transform.position, out navHit, 2, NavMesh.AllAreas);
        if(agent.enabled)
            agent.SetDestination(lever.transform.position);
        if (Vector3.SqrMagnitude(transform.position - lever.transform.position) < 1)
        {
            if (lever.GetComponent<ControlPalanca>().caido && lever2.GetComponent<ControlPalanca>().caido)
            {
                agent.SetDestination(transform.position);
                return TaskStatus.Success;
            }
            else
            {
                GameObject x = lever;
                lever = lever2;
                lever2 = x;
            }
            return TaskStatus.Running;
        }
        else return TaskStatus.Running;
    }
}
