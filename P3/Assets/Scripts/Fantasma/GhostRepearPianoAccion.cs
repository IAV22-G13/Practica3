using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;

public class GhostRepearPianoAccion : Action
{
    GameBlackboard blackboard;
    NavMeshAgent agent;
    GameObject piano;
    public override void OnAwake()
    {
        agent = GetComponent<NavMeshAgent>();
        blackboard = GameObject.FindGameObjectWithTag("Blackboard").GetComponent<GameBlackboard>();
        piano = blackboard.piano;
    }

    public override TaskStatus OnUpdate()
    {
        agent.SetDestination(piano.transform.position);
        if (Vector3.SqrMagnitude(transform.position - piano.transform.position) < 1)
        {
            agent.SetDestination(transform.position);
            piano.GetComponent<ControlPiano>().tocado = false;
            return TaskStatus.Success;
        }       
        return TaskStatus.Success;
    }
}
