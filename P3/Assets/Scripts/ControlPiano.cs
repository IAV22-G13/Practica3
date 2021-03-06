using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Pone el piano en estado tocado cuando se colisiona otro objeto con él
 */

public class ControlPiano : MonoBehaviour
{
    public GameObject ghost;
    public bool tocado = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Cantante>() || other.gameObject.GetComponent<Player>() || other.gameObject.GetComponent<Accion>() || other.gameObject.GetComponent<Atack>() || other.gameObject.GetComponent<Capture>()) return;
        tocado = false; // Solo lo hace el fantasma
    }

    public void Interact()
    {
        tocado = true;
        GetComponent<AudioSource>().Play();
    }

    public void Componing()
    {
        GetComponent<AudioSource>().Play();
    }
}
