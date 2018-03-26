using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu]
public class GameEvent : ScriptableObject, ISubscribeable
{
    public List<IListener> Listeners = new List<IListener>();
    public void Raise()
    {
        Raise(null);
    }

    public void Raise(params Object[] args)
    {
        for(int i = Listeners.Count - 1; i >= 0; i--)
        {
            Listeners[i].OnEventRaised(args);
        }
    }

    public void Subscribe(IListener listener)
    {
        Listeners.Add(listener);
    }

    public void Unsubscribe(IListener listener)
    {
        Listeners.Remove(listener);
    }
}
