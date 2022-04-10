using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;

/*
 * Condicion de si el piano esta roto
 */
public class PianoHittedCondition : Conditional
{
    GameBlackboard blackboard;
    public override void OnAwake()
    {
        blackboard = GameObject.FindGameObjectWithTag("Blackboard").GetComponent<GameBlackboard>();
    }

    // Update is called once per frame
    public override TaskStatus OnUpdate()
    {
        if (blackboard.pianoed)
            return TaskStatus.Success;

        return TaskStatus.Failure;
    }
}
