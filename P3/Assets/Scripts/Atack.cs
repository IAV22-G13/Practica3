using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        GameObject ghost = GameObject.FindGameObjectWithTag("Blackboard").GetComponent<GameBlackboard>().ghost;
        if (other.gameObject == ghost)
        {
            transform.parent.GetComponent<Player>().attackGhost();
        }
    }
}