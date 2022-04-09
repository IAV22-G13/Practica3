using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capture : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        GameObject singer = GameObject.FindGameObjectWithTag("Blackboard").GetComponent<GameBlackboard>().singer;
        if (other.gameObject == singer)
        {
            transform.parent.GetComponent<Player>().captureSinger();
            Debug.Log("aqui si");
        }
    }
}