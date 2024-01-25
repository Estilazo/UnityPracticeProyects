using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineryInventoryManager : MonoBehaviour
{

    [SerializeField] private GameObject inventoryItem;

    [SerializeField] private Transform itemInstanceTransform;

    private void Start()
    {
        
    }

    public void InstanceMachineryOnInventory(MachineryVars machinery)
    {
        GameObject instancedItem;
        instancedItem = Instantiate(inventoryItem, itemInstanceTransform);
        instancedItem.GetComponent<MachineryInventoryItem>().SetName(machinery.name);

    }
}
