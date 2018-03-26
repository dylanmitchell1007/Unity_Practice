using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour {

    public Item item;
    public bool pickedup = false;

    private void OnTriggerEnter(Collider other)
    {
        if (pickedup == true) return;
        pickedup = true;
        other.GetComponent<InventoryBehaviour>().AddToInventory(item);
        GetComponent<MeshRenderer>().material.color = Color.cyan;
    }
}
