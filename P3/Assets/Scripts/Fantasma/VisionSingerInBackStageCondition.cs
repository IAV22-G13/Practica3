using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;

/*
 * Devuelve Success cuando la puerta de la celda esta abierta
 */

public class VisionSingerInBackStageCondition : Conditional
{
    GameBlackboard blackboard;

    public override void OnAwake()
    {
        blackboard = GameObject.FindGameObjectWithTag("Blackboard").GetComponent<GameBlackboard>();
    }

    public override TaskStatus OnUpdate()
    {
        if(Vector3.SqrMagnitude(blackboard.backStage.transform.position - blackboard.singer.transform.position) < 1.5f)       
            return TaskStatus.Success;

        return TaskStatus.Failure;
    }
}