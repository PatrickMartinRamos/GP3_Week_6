using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class serializableValuePair<Tkey, Tvalue>
{
    public Tkey Key;
    public Tvalue Value;

    public serializableValuePair(Tkey key, Tvalue value)
    {
        Key = key;
        Value = value;
    }
}
public class inventorySystem : MonoBehaviour
{
    [SerializeField]
    private Dictionary<int,Items> inventory = new Dictionary<int,Items>();
    [SerializeField]
    List<serializableValuePair<int, Items>> inventoryList = new List<serializableValuePair<int, Items>>();

    public void SyncListWithDictionary()
    {
        inventoryList.Clear();
        foreach (var pair in inventory)
        {
            inventoryList.Add(new serializableValuePair<int, Items>(pair.Key, pair.Value));
        }
    }
    public void AddItem(Items items)
    {
        if(inventory.ContainsKey(items.ID))
        {
            //update quantity
        }
        else
        {
            inventory[items.ID] = items;
        }
        SyncListWithDictionary();
    }

    public bool RemoveItem(int itemID)
    {
        bool _remove = inventory.Remove(itemID);
        if(_remove)
        {
            SyncListWithDictionary();
        }
        return _remove;
    } 

    public bool CheckItem(int itemID)
    {
        return inventory.ContainsKey(itemID);
    }
}
