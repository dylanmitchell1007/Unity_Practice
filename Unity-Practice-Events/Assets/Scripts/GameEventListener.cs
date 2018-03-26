using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventListener : MonoBehaviour, IListener
{
    public GameEvent GameEvent;
    public GameObject Sender;
    public GameEventResponse Response;
    

    private void OnEnable()
    {   
        GameEvent.Subscribe(this);
    }

    public void OnEventRaised(params Object[] args)
    {
        var sender = args[0] as GameObject;
        if(Sender == sender)
            Response.Invoke(args);
    }

    private void OnDisable()
    {
        GameEvent.Unsubscribe(this);
    }
}
