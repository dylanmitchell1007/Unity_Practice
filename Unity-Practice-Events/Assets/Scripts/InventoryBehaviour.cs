using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBehaviour : MonoBehaviour
{
    public Inventory _inventory;
    public void AddToInventory(Item item)
    {
        _inventory.items.Add(item);
    }

    public void RemoveFromInventory(Item item)
    {
        _inventory.items.Remove(item);
    }
}
