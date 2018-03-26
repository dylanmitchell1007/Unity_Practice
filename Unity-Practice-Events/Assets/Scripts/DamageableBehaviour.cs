using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageableBehaviour : MonoBehaviour, IDamageable
{    
    public GameEvent DamageTaken;
    public GameEvent DeathEvent;
    public int Health;
    public void TakeDamage(int amount)
    {        
        var newamount = Health - amount;
        if (newamount <= 0)
            DeathEvent.Raise(gameObject);
        
        Health = newamount;
        Debug.Log(Health);
        DamageTaken.Raise(gameObject);
    } 
}
