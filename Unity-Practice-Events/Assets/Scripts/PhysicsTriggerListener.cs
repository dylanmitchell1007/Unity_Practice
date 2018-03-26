using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTriggerListener : MonoBehaviour
{
    public GameEvent EventTriggerEntered;
    public GameEvent EventTriggerExit;
    public GameEvent EventTriggerStay;

    private void OnTriggerEnter(Collider other)
    {
        EventTriggerEntered.Raise(gameObject, other.gameObject);    
    }
    private void OnTriggerExit(Collider other)
    {
        EventTriggerExit.Raise(gameObject, other.gameObject);
    }

    private void OnTriggerStay(Collider other)
    {
        EventTriggerStay.Raise(gameObject, other.gameObject);
    }
}
