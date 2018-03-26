using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Raising some events
/// </summary>
public class GameStateBehaviour : MonoBehaviour
{
    public GameEvent EventAwake;
    public GameEvent EventEnabled;
    public GameEvent EventStart;
    public GameEvent EventUpdate;
    public GameEvent EventDisabled;

    private void Awake()
    {
        EventAwake.Raise(this);
    }
    private void OnEnable()
    {
        EventEnabled.Raise(this);
    }
    // Use this for initialization
    private void Start()
    {
        EventStart.Raise(this);
    }

    // Update is called once per frame
    private void Update()
    {
        EventUpdate.Raise(this);
    }

    private void OnDisable()
    {
        EventDisabled.Raise(this);
    }
}
