using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public Item CurrentItem;
    public int currentItemIndex;
    public Inventory PlayerInventory;
    private void Start()
    {
        currentItemIndex = 0;
    }
    private void Update()
    {
        if (PlayerInventory.items.Count > 0)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                var nextindex = currentItemIndex - 1;
                if (nextindex <= 0)
                    currentItemIndex = 0;                
                    
                CurrentItem = PlayerInventory.items[currentItemIndex];
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                var nextindex = currentItemIndex + 1;
                if (nextindex >= PlayerInventory.items.Count - 1)
                    currentItemIndex = PlayerInventory.items.Count - 1;
                else
                    currentItemIndex = nextindex;
                CurrentItem = PlayerInventory.items[currentItemIndex];
            }
        }
    }
}
