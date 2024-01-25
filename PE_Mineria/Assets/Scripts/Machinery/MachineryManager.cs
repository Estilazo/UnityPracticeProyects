using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineryManager : MonoBehaviour
{
    [SerializeField] private GameObject machineryPrefab;

    [SerializeField] private MachineryInventoryManager inventoryManager;

    [SerializeField] private List<MachineryVars> machineryVars;

    [SerializeField] private Dictionary<Minerals, Color> mineralColors;

    public event Action<MachineryVars> OnMachineryFound;

    public void SetupColorDictionary(List<MineralVars> minerals)
    {
        mineralColors = new Dictionary<Minerals, Color>();

        foreach (MineralVars mineral in minerals)
        {
            mineralColors.Add(mineral.mineralType, mineral.mineralColor);
        }
    }

    private void PrepareMachinery(Minerals mineral)
    {
        foreach (var machinery in machineryVars) {
        
            if (machinery.mineralType == mineral)
            {
                OnMachineryFound?.Invoke(machinery);
            }
        }
    }



}
