using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineryInventoryManager : MonoBehaviour
{

    [SerializeField] private GameObject inventoryItem;

    [SerializeField] private Transform itemInstanceTransform;

    [SerializeField] private List<MachineryVars> machineryVars;

    public class InventoryItem
    {
        public string machineryName;
        public string machineryType;
    }

    private void Start()
    {
        
    }

    private void InstanceInitialMachinery()
    {
        new InventoryItem { };
    }
}
