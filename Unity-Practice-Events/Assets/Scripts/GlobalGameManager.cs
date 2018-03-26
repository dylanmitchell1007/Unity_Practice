using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GlobalGameManager : ScriptableObject
{
    public void Print(string info)
    {
        Debug.Log(info);
    }

    public void OnTriggerEnterHandler(Object[] args)
    {
        var sender = args[0] as GameObject;
        var other = args[1] as GameObject;
        Print(string.Format("the trigger of {0} has been entered by {1} ", sender, other));
    }
}


[System.Serializable]
public class GameEventResponse : UnityEvent<Object[]> { }

public interface IListener
{
    void OnEventRaised(params Object[] args);
}

public interface ISubscribeable
{
    void Raise(params Object[] args);
    void Subscribe(IListener listener);
    void Unsubscribe(IListener listener);
}
