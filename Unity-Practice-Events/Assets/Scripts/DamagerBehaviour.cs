using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagerBehaviour : MonoBehaviour, IDamager
{
    public GameEvent DamageDone;

    public Weapon weapon;
    
    public void DoDamage(IDamageable damageable)
    {        
        if (damageable == null)
            return;
        damageable.TakeDamage(weapon.Power);
        DamageDone.Raise(gameObject);
    }

    public void OnTriggerEnterEvent(Object[] args)
    {
        var sender = args[0] as GameObject;
        var other = args[1] as GameObject;
        if (sender == null)
            return;
        IDamageable damageable = other.GetComponent<IDamageable>();
        DoDamage(damageable);
    }
}
