using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibleitem : MonoBehaviour
{
    public string _itemName;
    public int _itemID;
    public int _quantity;

    inventorySystem _inventorySystem;

    private void Start()
    {
        _inventorySystem = GameObject.FindGameObjectWithTag("Player").GetComponent<inventorySystem>(); 
    }

    public void collectItem()
    {
        Items itemToAdd = new Items(_itemName, _itemID,_quantity);
        _inventorySystem.AddItem(itemToAdd);
        Destroy(gameObject);
    }
}
