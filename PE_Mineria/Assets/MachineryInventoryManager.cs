using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineryInventoryManager : MonoBehaviour
{

    [SerializeField] private GameObject inventoryItem;

    [SerializeField] private Transform itemInstanceTransform;

    private MineralSlot slotToInstanceIn;


    public void ActivateMachineryInventory(MineralSlot slot)
    {
        slotToInstanceIn = slot;
        this.gameObject.SetActive(true);
    }

    public void InstanceMachineryOnInventory(MachineryVars machinery)
    {
        GameObject instancedItem;
        instancedItem = Instantiate(inventoryItem, itemInstanceTransform);

        MachineryInventoryItem itemScript = instancedItem.GetComponent<MachineryInventoryItem>();

        itemScript.SetVars(machinery);
    }

    public  bool InstanceMachineOnSlot(MachineryVars machinery)
    {
        if (!slotToInstanceIn.hasMachine && machinery.mineralType == slotToInstanceIn.slotType)
        {
            slotToInstanceIn.InstanceMachinery(machinery);
            return true;
        }
        else return false;
    }


}
