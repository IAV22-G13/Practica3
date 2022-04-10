using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;

public class GhostComponingAction : Action
{
    NavMeshAgent agent;
    GameObject piano;
    float timer;
    float touch = 3;

    public override void OnAwake()
    {
        agent = GetComponent<NavMeshAgent>();
        piano = GameObject.FindGameObjectWithTag("Blackboard").GetComponent<GameBlackboard>().piano;
        
    }

    public override TaskStatus OnUpdate()
    {
        if(!GameObject.FindGameObjectWithTag("Blackboard").GetComponent<GameBlackboard>().imprisoned)
            return TaskStatus.Success;

        if (agent.enabled)
            agent.SetDestination(piano.transform.position);

        timer -= Time.deltaTime;
        if (Vector3.SqrMagnitude(transform.position - piano.transform.position) < 1.5f && timer <= 0)
        {
            timer = touch;
            piano.GetComponent<ControlPiano>().Componing();
        }

        return TaskStatus.Running;
    }
}
