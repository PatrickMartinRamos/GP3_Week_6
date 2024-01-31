using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class itemCollections : MonoBehaviour
{
    //public var
    public float detectionRange;
    public LayerMask itemlayerMask;
    public KeyCode itemCollectionKey;

    public inventorySystem inventorySystems;

    private void Update()
    {
        DetectItems();
    }
    public void DetectItems()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position,Vector3.forward);

        if(Physics.Raycast(ray, out hit, detectionRange, itemlayerMask))
        {
            Debug.Log("item detected: " + hit.collider.gameObject.name);
        }
        if(Input.GetKeyDown(itemCollectionKey))
        {
            hit.collider.gameObject.GetComponent<collectibleitem>().collectItem();
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, Vector3.forward * detectionRange);
    }
    public void collectItem(Items item)
    {
        inventorySystems.AddItem(item);
    }
}
