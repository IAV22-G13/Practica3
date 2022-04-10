using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;

public class GhostComponingAction : Action
{
    public override void OnAwake()
    {
        
    }

    public override TaskStatus OnUpdate()
    {
        
        return TaskStatus.Success;
        
        return TaskStatus.Running;
    }
}
