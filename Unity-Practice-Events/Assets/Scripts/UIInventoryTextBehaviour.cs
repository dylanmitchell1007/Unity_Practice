using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventoryTextBehaviour : MonoBehaviour
{
    [SerializeField]
    Inventory inventory;
    public UnityEngine.UI.Text Text;
    string itemnames = "";
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        itemnames = "";
        foreach(var item in inventory.items)
        {
            itemnames += item.name + " \n";
        }
        Text.text = itemnames;
	}
}
