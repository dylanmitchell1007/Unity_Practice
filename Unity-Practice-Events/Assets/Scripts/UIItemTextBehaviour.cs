using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIItemTextBehaviour : MonoBehaviour
{

    public Item item;
	// Use this for initialization
	void Start ()
    {
        GetComponent<UnityEngine.UI.Text>().text = item.name;
	}
	
}
