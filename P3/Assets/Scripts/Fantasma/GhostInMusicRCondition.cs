using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;

public class GhostInMusicRCondition : Conditional
{
    GameObject musicRoom;
    public override void OnAwake()
    {
        musicRoom = GameObject.FindGameObjectWithTag("Blackboard").GetComponent<GameBlackboard>().musicRoom;
    }

    public override TaskStatus OnUpdate()
    {
        if (Vector3.SqrMagnitude(transform.position - musicRoom.transform.position) < 1.5f)
            return TaskStatus.Success;

        return TaskStatus.Failure;
    }
}
