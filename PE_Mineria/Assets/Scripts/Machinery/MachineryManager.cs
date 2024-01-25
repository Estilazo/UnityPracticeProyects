using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineryManager : MonoBehaviour
{
    [SerializeField] private MachineryInventoryManager inventoryManager;

    [SerializeField] private List<MachineryVars> machineryVars;

    [SerializeField] private Dictionary<Minerals, Color> mineralColors;

    public event Action<MachineryVars> OnMachineryFound;

    private void Start()
    {
        OnMachineryFound += inventoryManager.InstanceMachineryOnInventory;
    }

    public void SetupColorDictionary(List<MineralVars> minerals)
    {
        mineralColors = new Dictionary<Minerals, Color>();

        foreach (MineralVars mineral in minerals)
        {
            mineralColors.Add(mineral.mineralType, mineral.mineralColor);
        }
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
