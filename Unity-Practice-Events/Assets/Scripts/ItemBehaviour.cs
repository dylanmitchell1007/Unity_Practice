using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour {

    public Item item;
    public bool pickedup = false;
    public GameEvent ItemPickedUp;
    
    public void OnTriggerEnterEventHandler(Object[] args)
    {
        var sender = args[0] as GameObject;
        var other = args[1] as GameObject;
        if (sender != gameObject || pickedup)
            return;
        
        pickedup = true;
        var ib = other.GetComponent<InventoryBehaviour>();
        if (ib == null)
        {
            Debug.Log("no inventory on " + other.name);
            return;
        }

        ib.AddToInventory(item);
        ItemPickedUp.Raise(this, item);
        Destroy(gameObject, 1);
    }
}
