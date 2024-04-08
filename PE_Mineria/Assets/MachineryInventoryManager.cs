using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineryInventoryManager : MonoBehaviour
{

    [SerializeField] private GameObject inventoryItem;

    [SerializeField] private Transform itemInstanceTransform;

    private MineralSlot slotToInstanceIn;

    private List<MachineryInventoryItem> inventoryItems = new();

    private bool isFirst = true;

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
        inventoryItems.Add(itemScript);

        itemScript.SetVars(machinery);
        
        isFirst = false;

        if (!isFirst)
        {
            instancedItem.SetActive(false);
        }
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

    public bool BuyMachinery(int id)
    {
        foreach(MachineryInventoryItem item in inventoryItems)
        {
            if(item.GetMachineryID() == id)
            {
                item.gameObject.SetActive(true);
                return true;
            }

        }
        return false;
    }

}
