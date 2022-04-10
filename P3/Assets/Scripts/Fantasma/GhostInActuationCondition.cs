using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;

public class GhostInActuationCondition : Conditional
{
    GameBlackboard blackboard;

    public override void OnAwake()
    {
        blackboard = GameObject.FindGameObjectWithTag("Blackboard").GetComponent<GameBlackboard>();
    }

    public override TaskStatus OnUpdate()
    {
        if (Vector3.SqrMagnitude(blackboard.singer.transform.position - blackboard.backStage.transform.position) < 1.5f ||
            Vector3.SqrMagnitude(blackboard.singer.transform.position - blackboard.stage.transform.position) < 1.5f)
            return TaskStatus.Success;

        return TaskStatus.Failure;
    }
}
