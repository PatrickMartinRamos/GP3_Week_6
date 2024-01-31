using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dictionary : MonoBehaviour
{
    //dictionary(key type, value of the type)
    //1 item is considered as paired
    Dictionary<string, int> _bountyPirate = new Dictionary<string, int>()
    {
        { "luffy", 30000000},
        {"chopper" ,10000}
    };

    Dictionary<string, string> _celestialDragon = new Dictionary<string, string>()
    {
        { "Saturn", "Egghead"}
    };

    public void Start()
    {
      
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            _updateBounty("luffy", 6000000);
            Debug.Log("pirate counts: " + _bountyPirate.Count);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _addPirate("Sir Charles", 69420);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(_celestialDragon.ContainsKey("Saturn") && _celestialDragon.ContainsValue("Egghead"))
            {
                _deletePirates("Sir Charles");
            }
        }
    }

    public void _deletePirates(string pirateName)
    {
        _bountyPirate.Remove(pirateName);
    }
    //add pirate to the dictionary
    public void _addPirate(string pirateName, int _bounty)
    {
        _bountyPirate.Add(pirateName, _bounty);
    }
    //Update bounty
    public void _updateBounty(string pirateName, int _newBounty)
    {
        _bountyPirate[pirateName] = _newBounty;
    }
}
