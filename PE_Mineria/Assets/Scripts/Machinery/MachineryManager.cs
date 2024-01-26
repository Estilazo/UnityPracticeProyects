using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineryManager : MonoBehaviour
{
    [SerializeField] private MachineryInventoryManager inventoryManager;

    [SerializeField] private List<MachineryVars> machineryVars;

    public event Action<MachineryVars> OnMachineryFound;

    private void Start()
    {
        OnMachineryFound += inventoryManager.InstanceMachineryOnInventory;
    }

    public void PrepareMachinery(Minerals mineral)
    {
        foreach (var machinery in machineryVars) {
        
            if (machinery.mineralType == mineral)
            {
                OnMachineryFound?.Invoke(machinery);
            }
        }
    }
}
