using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;

public class GhostAndSingerSameRoomCondition : Conditional
{
    GameBlackboard blackboard;
    public override void OnAwake()
    {
        blackboard = GameObject.FindGameObjectWithTag("Blackboard").GetComponent<GameBlackboard>();
    }

    public override TaskStatus OnUpdate()
    {
        if (Vector3.SqrMagnitude(blackboard.ghost.transform.position - blackboard.singer.transform.position) < 7.5f && 
            blackboard.ghost.transform.position.y - blackboard.singer.transform.position.y < 0.3f)
            return TaskStatus.Success;

        return TaskStatus.Failure;
    }
}
