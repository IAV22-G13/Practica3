using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;

public class GhostLetSingerAction : Action
{
    GameBlackboard blackboard;

    public override void OnAwake()
    {
        blackboard = GameObject.FindGameObjectWithTag("Blackboard").GetComponent<GameBlackboard>();
    }

    public override TaskStatus OnUpdate()
    {
        blackboard.singer.transform.parent = null;
        blackboard.singer.GetComponent<Cantante>().capturada = false;
        return TaskStatus.Success;
    }
}
